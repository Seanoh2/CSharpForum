using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace forumwebsiteCA3.Models
{
    public class posts
    {
        [Key]
        public int postID { get; set; }

        public String userID { get; set; }
        public int forumID { get; set; }
        public int isLink { get; set; }
        public String title { get; set; }
        public String content { get; set; }
        public int score { get; set; }

    }
}