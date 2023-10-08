using Class_task1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practise_validation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(SignUp signUp)
        {

            if (ModelState.IsValid)
            { 
                return RedirectToAction("Index");
            }
            return View(signUp);

        }
        [HttpGet]
        public ActionResult Signup()
        {


            return View();

        }



    }
}