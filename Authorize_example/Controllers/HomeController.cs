using Authorize_example.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Authorize_example.Controllers
{
 
    public class HomeController : Controller
    {
        private DbContext context = new ApplicationDbContext();

        public ActionResult Index()
        {
           
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));


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
    }
}