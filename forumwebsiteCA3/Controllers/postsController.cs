using forumwebsiteCA3.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace forumwebsiteCA3.Controllers {
    public class postsController : Controller {
        private ApplicationDbContext _context;

        public postsController() {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing) {
            _context.Dispose();
        }

        public ActionResult Index(int id) {
            var post = from p in _context.posts select p;
            return View("board", post);
        }

        public ActionResult goToPostById(int postid) {
            var post = _context.posts.Where(p => p.postID == postid).FirstOrDefault();
            if ((post.content).Contains("youtube.com")){
                post.content = "https://www.youtube.com/embed/" + (post.content).Substring((post.content).LastIndexOf('=') + 1);
            }
            var comments = _context.comments.Where(c => c.postID == postid);
            var users = from u in _context.AspNetUsers select u;
            var viewModel = new commentsPost();
            viewModel.post = post;
            viewModel.comments = comments;
            viewModel.users = users;
            return View("index", viewModel);
        }

        public ActionResult addPost(int forumID) {
            posts post1 = new posts();
            post1.forumID = forumID;
            post1.userID = User.Identity.GetUserId();
            post1.score = 0;
            return View(post1);
        }

        public ActionResult Edit(int postid)
        {
            var editPost = _context.posts.Where(p => p.postID == postid).FirstOrDefault();
            return View("editPost",editPost);
        }

        public ActionResult Delete(int postid)
        {
            var deletePost = _context.posts.Where(p => p.postID == postid).FirstOrDefault();
            _context.posts.Remove(deletePost);
            _context.SaveChanges();
            return RedirectToAction("goToBoardById", "forums", new { deletePost.forumID });
        }

            public ActionResult editPostToDB(posts editPost)
        {
            var oldPost = _context.posts.Where(p => p.postID == editPost.postID).FirstOrDefault();
            _context.Entry(oldPost).CurrentValues.SetValues(editPost);   
            _context.SaveChanges();
            return RedirectToAction("goToPostById", "posts", new { oldPost.postID });
        }

        public ActionResult addPostToDB(posts model) {
            _context.posts.Add(model);
            _context.SaveChanges();

            return RedirectToAction("goToBoardById", "forums", new { model.forumID });
        }

        public ActionResult postSuccessful() {
            return View("postSuccessful");
        }
    }
}