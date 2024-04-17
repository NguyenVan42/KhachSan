using System;
using System.Web;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using Hotelier.Helper;
using Hotelier.Models;

namespace Hotelier.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            StaticCustomer.ListStaticCustomer.Add(new Customers()
            {
                FirstName = "Mai",
                LastName = "Nguyen",
                Email = "ann2k@gmail.com",
                Phone = "0985721746",
                Address = "Ha Nam, Vietnam",
                IdentityCard = "0163875672969",
                Password = "$2y$10$yTVfb5kClxTbNXyreuc2yuOfZabVq.hb78xxSUBx71EklyIOuncPe",
                CreateDate = DateTime.Now,
                Status = 1,
                Level = 2,
                Note = ""
            });
            var add = StaticCustomer.ListStaticCustomer;
            return View(add);
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

        public ActionResult SubmitInformationCustomer(string FirstName, string LastName, string Email, string Phone, string Address, string IdentityCard)
        {
            StaticCustomer.ListStaticCustomer.Add(new Customers()
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Phone = Phone,
                Address = Address,
                IdentityCard = IdentityCard
            });
            return RedirectToAction("Index");
        }
    }
}