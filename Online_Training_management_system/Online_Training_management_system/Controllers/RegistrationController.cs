using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTMS_DAL;

namespace Online_Training_management_system.Controllers
{
    public class RegistrationController : Controller
    {



        //To Display Registration Table To Show Registration Data
        public ActionResult Index()
        {
            
            Repositary rep = new Repositary();
            List<Registration> reglist = rep.ViewRegistration();
            List<Models.Registrations> modlist = new List<Models.Registrations>();
            foreach(var i in reglist)
            {
                Models.Registrations mod = new Models.Registrations();
                mod.RegistrationId = i.RegistrationId;
                mod.TrainingName = i.Training.TrainingName;
                mod.EmailAddress = i.EmailAddress;
                mod.FeesPaid = i.FeesPaid;
                mod.Status = i.Status;
                modlist.Add(mod);
            }
            return View(modlist);
        }




        //To Perform Registration For Training By The User
        [HttpGet]
        public ActionResult AddRegistration(int trainingid)
        {
            Repositary rep = new Repositary();
            var res = rep.GetTrainingDetails(trainingid);
            Models.Trainings mod = new Models.Trainings();
            mod.TrainingName = res.TrainingName;
            mod.Fees = res.Fees;
            TempData["fees"] = mod.Fees;
            return View(mod);
        }



        [HttpPost]
        public ActionResult AddRegistration(Models.Registrations mod)
        {
            
            Repositary rep = new Repositary();
            Registration reg = new Registration();
            reg.RegistrationId = mod.RegistrationId;
            reg.TrainingId = mod.TrainingId;
            reg.EmailAddress = (Session["EmailId"]).ToString();
            reg.FeesPaid = System.Convert.ToDecimal(TempData["fees"]);
            reg.Status = mod.Status;
            rep.RegisterTraining(reg);
            return RedirectToAction("Index");
        }

        
        

        //To Perform Edit Operations On Registration Data
        [HttpGet]
        public ActionResult EditRegistration(int registrationid)
        {
            Repositary rep = new Repositary();
            var register = rep.GetRegistrationDetails(registrationid);
            Models.Registrations mod = new Models.Registrations();
            mod.RegistrationId = register.RegistrationId;
            mod.TrainingId = register.TrainingId;
            mod.EmailAddress = register.EmailAddress;
            mod.FeesPaid = register.FeesPaid;
            mod.Status = register.Status;
            mod.TrainingName = register.Training.TrainingName;
            return View(mod);
        }



        [HttpPost]
        public ActionResult EditRegistration(int registrationid,Models.Registrations mod)
        {
            Repositary rep = new Repositary();
            var result = rep.GetRegistrationDetails(registrationid);
            Registration reg = new Registration();
            reg.RegistrationId = result.RegistrationId;
            reg.TrainingId = result.TrainingId;
            reg.EmailAddress = result.EmailAddress;
            reg.FeesPaid = result.FeesPaid;
            reg.Status = mod.Status;
            rep.EditRegistration(reg);
            return RedirectToAction("Index");
        }
        





        //To Perform Delete Operation On Registration Table
        [HttpGet]
        public ActionResult Deleteregistration(int registrationid)
        {
            Repositary rep = new Repositary();
            var result = rep.GetRegistrationDetails(registrationid);
            Models.Registrations mod = new Models.Registrations();
            mod.RegistrationId = result.RegistrationId;
            mod.TrainingId = result.TrainingId;
            mod.EmailAddress = result.EmailAddress;
            mod.FeesPaid = result.FeesPaid;
            mod.Status = result.Status;
            mod.TrainingName = result.Training.TrainingName;
            return View(mod);
        }



        [HttpPost]
        public ActionResult Deleteregistration(int registrationid,Models.Registrations mod)
        {
            Repositary rep = new Repositary();
            rep.DeleteRegistration(registrationid);
            return RedirectToAction("Index");
        }







        //To Display Registration Details Based On Registration Id
       [HttpGet]
       public ActionResult Details(int registrationid)
        {
            Repositary rep = new Repositary();
            var result = rep.GetRegistrationDetails(registrationid);
            Models.Registrations mod = new Models.Registrations();
            mod.RegistrationId = result.RegistrationId;
            mod.TrainingId = result.TrainingId;
            mod.EmailAddress = result.EmailAddress;
            mod.FeesPaid = result.FeesPaid;
            mod.Status = result.Status;
            mod.TrainingName = result.Training.TrainingName;
            return View(mod);
        }


    }
}