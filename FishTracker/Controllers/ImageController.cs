using System;
using System.IO;
using FishTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Microsoft.AspNetCore.Hosting.Server;

namespace FishTracker.Controllers
{
    public class ImageController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Image imageModel)
        {
            string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
            string extension = Path.GetExtension(imageModel.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            imageModel.ImagePath = "~/Image/" + fileName;
            fileName = Path.Combine(IServer.MapPath("~/Image/"), fileName);
            imageModel.ImageFile.saveas(fileName);
            return View();
        }
    }
}