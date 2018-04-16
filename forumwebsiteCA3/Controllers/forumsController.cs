using forumwebsiteCA3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace forumwebsiteCA3.Controllers
{
    public class forumsController : Controller
    {
        private ApplicationDbContext _context;

        public forumsController()
        {
            _context = new ApplicationDbContext();
            //test comment
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}