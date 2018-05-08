using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace forumwebsiteCA3.Models
{
    public class comments
    {
        [Key]
        public int commentID { get; set; }

        public int postID { get; set; }
        public String senderID { get; set; }
        public DateTime time { get; set; }
        public String content { get; set; }

    }
}