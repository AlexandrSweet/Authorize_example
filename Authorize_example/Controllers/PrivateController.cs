using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authorize_example.Controllers
{
    [Authorize(Roles ="admin")]
    [RequireHttps]
    public class PrivateController : Controller
    {
        // GET: Private
      
        [OutputCache(Duration =120)]
        public ActionResult Index()
        {
            return View();
        }
    }
}