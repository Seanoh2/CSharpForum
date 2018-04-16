using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace forumwebsiteCA3.Models
{
    public class moderators
    {
        [Key]
        public int moderatorID { get; set; }

        public int userID { get; set; }
        public int forumID { get; set; }

    }
}