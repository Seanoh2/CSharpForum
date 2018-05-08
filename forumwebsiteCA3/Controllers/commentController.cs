using forumwebsiteCA3.Models;
using Microsoft.AspNet.Identity;
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

        public ActionResult addComment(int postID) {
            comments comment1 = new comments();
            comment1.postID = postID;
            comment1.senderID = User.Identity.GetUserId();
            comment1.time = DateTime.Now;   
            return View(comment1);
        }

        public ActionResult addCommentToDB(comments model) {
            _context.comments.Add(model);
            _context.SaveChanges();
            return RedirectToAction("commentSuccessful", "comment");
        }

        public ActionResult Edit(int commentID)
        {
            var comment = _context.comments.Where(p => p.commentID == commentID).FirstOrDefault();
            comment.time = DateTime.Now;

            return View("editComment", comment);
        }

        public ActionResult Delete(int commentID)
        {
            var comment = _context.comments.Where(p => p.commentID == commentID).FirstOrDefault();
            var postID = comment.postID;
            _context.comments.Remove(comment);
            _context.SaveChanges();

            return RedirectToAction("goToPostById", "posts", new { postID });
        }

        [HttpPost]
        public ActionResult editCommentToDB(comments editComment)
        {
            var comment = _context.comments.Where(p => p.commentID == editComment.commentID).FirstOrDefault();
            comment = editComment;
            _context.SaveChanges();

            return RedirectToAction("goToPostById", "posts", new { comment.postID });
        }

        public ActionResult commentSuccessful() {
            return View("commentSuccessful");
        }
    }
}