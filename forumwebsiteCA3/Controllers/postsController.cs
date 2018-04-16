using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace forumwebsiteCA3.Controllers
{
    public class postsController : Controller
    {
        // GET: posts
        public ActionResult Index()
        {
            return View();
        }
    }
}