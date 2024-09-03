using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using URSDAL;

namespace UserRegistrationsystemm.Controllers
{
    public class UserController : Controller
    {
       
        public ActionResult Index()
        {
            URSRepositary rep = new URSRepositary();
            List<UserDetail> userlist = rep.GetUserList();
            List<Models.UserDetails> modlist = new List<Models.UserDetails>();
            foreach(var i in userlist)
            {
                Models.UserDetails mod = new Models.UserDetails();
                mod.FirstName = i.FirstName;
                mod.LastName = i.LastName;
                mod.EmailId = i.EmailId;
                modlist.Add(mod);
            }
            return View(modlist);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.UserDetails mod)
        {
            URSRepositary rep = new URSRepositary();
            UserDetail usp = new UserDetail();
            usp.FirstName = mod.FirstName;
            usp.LastName = mod.LastName;
            usp.EmailId = mod.EmailId;
            usp.Password = mod.Password;
            rep.AddUser(usp);
            return RedirectToAction("Index");
        }



    }
}