using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticeASPNET.Models;

namespace PracticeASPNET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //Return a view called "Index"
        {
            return View();
        }

        public ActionResult AddRegister()
        {
            return View();
        }

        //Process's the actual form
        public ActionResult ProcessRegister(Register NewUser)
        {
            //Validation !!

            //Added the object NewProduct to the DB!

            //configuration

            ViewBag.FirstName = NewUser.FirstName;

            return View();
        }
    }
}