using MealNear.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MealNear.Controllers
{
    public class FormController : Controller
    {

        // GET: Form
        public ActionResult Create()
        {
            //Person person = new Person();
            return View();
        }

        [HttpPost]
        public ActionResult Save(Person person)
        {
            if (ModelState.IsValid)
            {
                return View("Details", person);
            }
            else return View("Create");
        }

        public ActionResult Details()
        {
            return View(new Person());
        }
        
        [HttpPost]
        public ActionResult Upload(Image img, HttpPostedFileBase file)
        {

            /*if (ModelState.IsValid)
            {
                if(file != null)
                {
                    file.SaveAs(HttpContext.Server.MapPath("~/Content/Images/") + file.FileName);
                    img.ImagePath = file.FileName;
                }
                
            }*/
            var path = "";
            if (file != null)
            {
                if (file.ContentLength > 0)
                {
                    //for checking uploaded file is image or not
                    if(Path.GetExtension(file.FileName).ToLower()==".jpg"
                        || Path.GetExtension(file.FileName).ToLower() == ".png"
                            || Path.GetExtension(file.FileName).ToLower() == ".gif"
                                || Path.GetExtension(file.FileName).ToLower() == ".jpeg")
                    {
                        path = Path.Combine(Server.MapPath("~/Content/Images"), file.FileName);
                        file.SaveAs(path);
                        img.ImagePath = file.FileName;
                        ViewBag.UploadSuccess = true;
                    }
                }
            }
            return View(img);
        }
    }
}