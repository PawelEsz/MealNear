using MealNear.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Web.Security;
using System.Net;

namespace MealNear.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult SendContactInfo(Person person)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var message = new MailMessage();
                    message.From = new MailAddress("praczak535@gmail.com", "Paweł Szopa");
                    //message.To = person.Email;
                    message.To.Add(new MailAddress(person.Email));
                    message.Subject = person.Title;
                    message.Body = person.Text;

                    var smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("praczak535@gmail.com", "");  // :)
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                    ViewBag.SendSuccess = true;
                    return View("Contact");
                }
                catch (Exception ex)
                {
                    return View("Index");
                }
            }
            else
            {
                return View("Contact");
            }
        }
    }
}