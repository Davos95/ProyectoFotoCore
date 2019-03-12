using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace ProyectoFotoCore.Tools
{

    public class ToolImage
    {        
        public static void UploadImage(IFormFile image, String path, String name)
        {
            String finalPath = "";
            if (name != null)
            {
                String type = image.ContentType.Split('/')[1];
                finalPath = Path.Combine(path, name + "." + type);
            }
            else
            {
                finalPath = Path.Combine(path, image.FileName);
            }

            using (var stream = new FileStream(finalPath, FileMode.Create))
            {
                image.CopyToAsync(stream);
            }
        }

        public static void RemoveImage(String image, String folder)
        {
            String path = Path.Combine(folder, image);
            File.Delete(path);
        }
        public static void MoveImage(String image, String originFolder, String destinationFolder)
        {
            String oPath = Path.Combine(originFolder, image);
            String dPath = Path.Combine(destinationFolder, image);
            File.Move(oPath, dPath);
        }

        public static void CreateFolder(String path, String name)
        {
            String routeFolder = Path.Combine(path, name);
            Directory.CreateDirectory(routeFolder);
        }
        public static void DeleteFolder(String path, String name)
        {
            String routeFolder = Path.Combine(path, name);
            Directory.Delete(routeFolder, true);
        }

        public static void RenameFolder(String path, String oldName, String newName)
        {
            String pathOldSession = Path.Combine(path, oldName);
            String pathNewSession = Path.Combine(path, newName);
            if (pathNewSession != pathOldSession)
            {
                Directory.Move(pathOldSession, pathNewSession);
            }

        }
    }
}
