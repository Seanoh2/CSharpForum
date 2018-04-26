using forumwebsiteCA3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace forumwebsiteCA3.Controllers
{
    public class postsController : Controller
    {
        private ApplicationDbContext _context;

        public postsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index(int id)
        {
            var post = from p in _context.posts select p;
            return View("board", post);
        }

        public ActionResult goToPostById(int id)
        {
            var post = _context.posts.Where(p => p.postID == id).FirstOrDefault();
            return View("index", post);
        }
    }
}