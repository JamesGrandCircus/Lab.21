using Lab._21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab._21.Controllers
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

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register newRegister)
        {

            if (ModelState.IsValid)
            {
                TempData["UserName"] = newRegister.FirstName;
                return RedirectToAction("Registered");
            }

            else
            {
                ViewBag.ErrorMessage = "The information you entered is invalid";
                return RedirectToAction("Register");
            }

        }

        public ActionResult Registered()
        {
            return View();
        }
    }
}