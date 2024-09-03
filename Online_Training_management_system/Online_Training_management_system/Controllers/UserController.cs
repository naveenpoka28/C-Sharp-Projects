using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTMS_DAL;

namespace Online_Training_management_system.Controllers
{
    public class UserController : Controller
    {


        //To Display Login Page And Perform Login Operations
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            string emailid = form["EmailAddress"];
            string password = form["Password"];
            Candidate candidat = new Candidate();
            Repositary rep = new Repositary();
            candidat = rep.Login(emailid, password);
            if(candidat==null)
            {
                ViewBag.ErrorMsg = "Invalid Login Details, Please Try Again";
                return View();
            }
            else
            {
                Session["EmailId"] = emailid;
                return RedirectToAction("Index","Training");
            }
            
        }



        //To Register A Candidate In To The Candidate Table
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Models.Candidate user)
        {
            Candidate cad = new Candidate();
            cad.FirstName = user.FirstName;
            cad.LastName = user.LastName;
            cad.EmailAddress = user.EmailAddress;
            cad.Password = user.Password;
            Repositary rep = new Repositary();
            rep.SignUp(cad);
            return RedirectToAction("ViewTrainings", "Training");
        }










    }
}