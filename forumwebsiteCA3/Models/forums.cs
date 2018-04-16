using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace forumwebsiteCA3.Models
{
    public class forums
    {
        [Key]
        public int forumID { get; set; }

        public String title { get; set; }
        public String description { get; set; }
        public String sidebar { get; set; }
        public String wiki { get; set; }

    }
}