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

        public ActionResult About() //Return a view called "About"
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() //Return a view called "Contact"
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowTime()
        {
            ViewBag.ServerTime = DateTime.Now;

            return View();//make a view called show time

        }

        public ActionResult ShowQuote()
        {
            string[] newQuotes = new string[] { "If you have nothing, are you a nillionaire?", "A hangover is the wrath of grapes.",
                "You can observe a lot by watching.", "Talk sense to a fool and he calls you foolish." };
            int r = new Random().Next(newQuotes.Length);
            ViewBag.Quotes = newQuotes[r];

            return View();//make a view called show quote

        }

        //Shows the form
        public ActionResult AddProduct()
        {
            return View();
        }


        //Process's the actual form
        public ActionResult ProcessNewProduct(Product NewProduct)
        {
            //Validation !!

            //Added the object NewProduct to the DB!

            //configuration

            ViewBag.ProductName = NewProduct.FirstName;

            return View();
        }
    }
}