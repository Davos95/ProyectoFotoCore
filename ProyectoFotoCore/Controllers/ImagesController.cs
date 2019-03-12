using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore.Provider;
using ProyectoFotoCore.Repositories;
using ProyectoFotoCore.Tools;

namespace ProyectoFotoCore.Controllers
{
    public class ImagesController : Controller
    {
        IRepositorySesion repoSesion;
        IRepositoryPhoto repoPhoto;
        PathProv prov;
        public ImagesController(IRepositorySesion repoS, IRepositoryPhoto repoP, PathProv prov)
        {
            this.repoSesion = repoS;
            this.repoPhoto = repoP;
            this.prov = prov;
        }

        // GET: Images
        public IActionResult UploadImages()
        {
            return View(this.repoSesion.GetSesions());
        }

        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            int idSesion = int.Parse(Request.Form["idSesion"].ToString());
            String sessionName = this.repoSesion.GetSESIONID(idSesion).Name;

            String path = prov.MapPath(Folders.Session, sessionName);

            foreach (IFormFile file in Request.Form.Files)
            {
                ToolImage.UploadImage(file, path, null);
                this.repoPhoto.InsertPhoto(file.FileName, idSesion);
            }

            return Json(true);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteImages(int idSesion)
        {
            String[] idPhotos = Request.Form["idPhotos"].ToArray();

            String sessionName = this.repoSesion.GetSESIONID(idSesion).Name;
            String path = prov.MapPath(Folders.Session, sessionName);

            foreach (String id in idPhotos)
            {
                String namePhoto = this.repoPhoto.GetPhotoById(int.Parse(id)).Picture;
                this.repoPhoto.RemovePhotos(int.Parse(id));
                ToolImage.RemoveImage(namePhoto, path);
            }

            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> OrderPhotos()
        {
            String[] idPhotos = Request.Form["idPhotos"].ToArray();
            for (int i = 0; i < idPhotos.Length; i++)
            {
                this.repoPhoto.OrderPhotos(int.Parse(idPhotos[i]), i);
            }
            return Json(true);
        }

        [HttpPost]
        public async Task<IActionResult> MovePhotos(int session)
        {
            String[] idPhotos = Request.Form["idPhotos"].ToArray();
            String oldSession = Request.Form["oldSession"];

            String sessionName = this.repoSesion.GetSESIONID(session).Name;
            String oldSessionName = this.repoSesion.GetSESIONID(int.Parse(oldSession)).Name;
            String oldFolder = prov.MapPath(Folders.Session, oldSessionName);
            String destinationFolder = prov.MapPath(Folders.Session, sessionName);

            foreach (String id in idPhotos)
            {
                int idPhoto = int.Parse(id);
                String imageName = this.repoPhoto.GetPhotoById(idPhoto).Picture;
                ToolImage.MoveImage(imageName, oldFolder, destinationFolder);
                this.repoPhoto.MovePhotosSesion(idPhoto, session);
            }
            return Json(true);
        }

    }
}