using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProyectoFotoCore.Filters;
using ProyectoFotoCore.Models;
using ProyectoFotoCore.Provider;
using ProyectoFotoCore.Repositories;
using ProyectoFotoCore.Tools;

namespace ProyectoFotoCore.Controllers
{

    [AuthorizedUser]
    public class SessionController : Controller
    {
        IRepositoryComision repoComision;
        IRepositorySesion repoSesion;
        IRepositoryPartner repoPartner;
        IRepositoryWork repoWork;
        IRepositoryPhoto repoPhoto;
        PathProv prov;
        public SessionController(IRepositoryComision repoC, IRepositorySesion repoS, IRepositoryPartner repoP, IRepositoryWork repoW, IRepositoryPhoto repoPh, PathProv prov)
        {
            this.repoComision = repoC;
            this.repoSesion = repoS;
            this.repoPartner = repoP;
            this.repoWork = repoW;
            this.repoPhoto = repoPh;
            this.prov = prov;
        }

        public IActionResult Sesion()
        {
            List<SESSION> sesions = this.repoSesion.GetSesions().ToList();
            return View(sesions);
        }


        #region Create Sesion
        // GET: CreateSesion
        public IActionResult CreateSesion()
        {
            return View(this.repoComision.GetCOMISIONS().ToList());
        }

        [HttpPost]
        public IActionResult CreateSesion(String name, String description, DateTime date, int comision)
        {
            String path = prov.MapPath(Folders.Session, name);
            ToolImage.CreateFolder(path);
            this.repoSesion.InsertSesion(name, description, date, comision);
            return RedirectToAction("Sesion");
        }
        #endregion

        public ActionResult DeleteSesion(int id, String name)
        {
            String path = prov.MapPath(Folders.Session);
            ToolImage.DeleteFolder(path);
            this.repoSesion.DeleteSesion(id);

            return RedirectToAction("Sesion");
        }

        #region Edit Sesion
        public IActionResult EditSesion(int id)
        {
            SESSION sesion = this.repoSesion.GetSESIONID(id);

            ViewBag.Date = sesion.DateSesion.ToString("yyyy-MM-dd");
            ViewBag.Comision = this.repoComision.GetCOMISIONS().ToList();
            ViewBag.Partner = this.repoPartner.GetPartners().ToList();
            ViewBag.Work = this.repoWork.GetWORKs().ToList();
            ViewBag.Workers = this.repoSesion.GetPartnerWorkBySesion(id);
            return View(sesion);
        }

        [HttpPost]
        public IActionResult EditSesion(String option, int idSesion, int? idPartner, int? idWork, String name, String description, DateTime? date, int? comision)
        {
            if (option == "ADD")
            {
                this.repoSesion.AddPartnerWorkIntoSesion(idSesion, idPartner.Value, idWork.Value);
            }
            else if (option == "MODIFY")
            {
                String sessionName = this.repoSesion.GetSESIONID(idSesion).Name;
                String path = prov.MapPath(Folders.Session);

                ToolImage.RenameFolder(path, sessionName, name);
                this.repoSesion.ModifySesion(idSesion, name, description, date.Value, comision.Value);
            }


            SESSION sesion = this.repoSesion.GetSESIONID(idSesion);
            ViewBag.Date = sesion.DateSesion.ToString("yyyy-MM-dd");
            ViewBag.Comision = this.repoComision.GetCOMISIONS().ToList();
            ViewBag.Partner = this.repoPartner.GetPartners().ToList();
            ViewBag.Work = this.repoWork.GetWORKs().ToList();
            ViewBag.Workers = this.repoSesion.GetPartnerWorkBySesion(idSesion);
            return View(sesion);
        }


        public IActionResult DeletePartnerWorkFromSesion(int idSesion, int idPartner, int idWork)
        {
            this.repoSesion.DeletePartnerWorkFromSesion(idSesion, idPartner, idWork);

            return RedirectToAction("EditSesion", "Session", new { id = idSesion });
        }
        #endregion

        public IActionResult ManagePhotos(int idSesion)
        {
            ViewBag.SessionName = this.repoSesion.GetSESIONID(idSesion).Name;
            ViewBag.Sessions = this.repoSesion.GetSesions().Where(x => x.Id != idSesion).ToList();
            return View(this.repoPhoto.GetPhotos(idSesion));
        }
    }
}