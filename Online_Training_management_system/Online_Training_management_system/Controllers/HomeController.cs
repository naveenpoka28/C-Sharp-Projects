using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Online_Training_management_system.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() //code to return about page
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() //code to return contact page
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Registrations() //code to check registration page
        {
            if(Session["EmailId"]==null)
            {
                ViewBag.Message = "Please Login To View The RegistrationTable";
                return RedirectToAction("ViewTrainings", "Training");
            }
            
            return RedirectToAction("Index", "Registration");
        }


        public ActionResult Training()  //Code to return all the available trainings
        {
            if (Session["EmailId"] == null)
            {
                return RedirectToAction("ViewTrainings", "Training");
            }
            return RedirectToAction("Index", "Training");

        }


        public ActionResult Logout()  //Code for the logout page
        {
            Session["EmailId"] = null;
            return RedirectToAction("ViewTrainings", "Training");
        }






    }
}