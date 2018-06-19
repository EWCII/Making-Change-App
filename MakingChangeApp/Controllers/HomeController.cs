using MakingChangeApp;
using MakingChangeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace trialdbmvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult MyPage()
        {
            return View();
        }

        public ActionResult SavingsTool()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                string toAddress = "ewcarringtonii@gmail.com";
                string subject = $"Message from {model.FromName}";
                string body = $@"Contact Name: {model.FromName}
                Contact Email: {model.FromEmail}

                Message Body:
 __________________________________________

                {model.Body}";
                Emailer.Send(toAddress, subject, body);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}