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
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var forum = from f in _context.forums select f;
            return View("allBoards", forum);
        }

        public ActionResult goToBoardById(int forumid)
        {

            var post = _context.posts.Where(p => p.forumID == forumid);

            return View("board", post);
        }

    }
}