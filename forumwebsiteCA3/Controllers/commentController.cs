using forumwebsiteCA3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace forumwebsiteCA3.Controllers {
    public class commentController : Controller {
        private ApplicationDbContext _context;

        public commentController() {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing) {
            _context.Dispose();
        }

        // GET: comment
        public ActionResult Index() {
            return View();
        }

        public ActionResult addComment() {
            comments comment1 = new comments();
            return View(comment1);
        }

        public ActionResult addCommentToDB(comments model) {
            _context.comments.Add(model);
            _context.SaveChanges();
            return RedirectToAction("commentSuccessful", "comment");
        }

        public ActionResult commentSuccessful() {
            return View("commentSuccessful");
        }
    }
}