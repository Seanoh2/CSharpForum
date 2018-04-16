using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace forumwebsiteCA3.Controllers
{
    public class commentController : Controller
    {
        // GET: comment
        public ActionResult Index()
        {
            return View();
        }
    }
}