using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OTMS_DAL;

namespace Online_Training_management_system.Controllers
{
    public class TrainingController : Controller
    {
        


        //To Display All Traing Data To Be Registered By The User Home Page
        public ActionResult ViewTrainings()
        {
            Repositary rep = new Repositary();
            List<Training> trilist = rep.GetAllTrainings();
            List<Models.Trainings> modlist = new List<Models.Trainings>();
            foreach(var i in trilist)
            {
                Models.Trainings mod = new Models.Trainings();
                mod.TrainingName = i.TrainingName;
                mod.StartDate = i.StartDate;
                mod.EndDate = i.EndDate;
                mod.Fees = i.Fees;
                modlist.Add(mod); 
            }
            return View(modlist);
        }





        //To Display Training Data Based On Training Id
        [HttpGet]
        public ActionResult ViewTrainingDetails(int trainingid)
        {
            Repositary rep = new Repositary();
            Training tr = new Training();
            tr = rep.GetTrainingDetails(trainingid);
            Models.Trainings mod = new Models.Trainings();
            mod.TrainingName = tr.TrainingName;
            mod.StartDate = tr.StartDate;
            mod.EndDate = tr.EndDate;
            mod.Fees = (decimal)tr.Fees;
            return View(mod);
        }




        //To Display Training Data Post Login To Perform Details And Register
        public ActionResult Index()
        {
            Repositary rep = new Repositary();
            List<Training> trilist = rep.GetAllTrainings();
            List<Models.Trainings> modlist = new List<Models.Trainings>();
            foreach (var i in trilist)
            {
                Models.Trainings mod = new Models.Trainings();
                mod.TrainingId = i.TrainingId;
                mod.TrainingName = i.TrainingName;
                mod.StartDate = i.StartDate;
                mod.EndDate = i.EndDate;
                
                modlist.Add(mod);
               
            }
            return View(modlist);

        }




    }
}