using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace forumwebsiteCA3.Models
{
    public class user
    {
        [Key]
        public int userID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public bool isAdmin { get; set; }

    }
}