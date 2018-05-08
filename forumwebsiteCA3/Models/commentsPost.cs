using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace forumwebsiteCA3.Models
{
    public class commentsPost
    {
        public posts post { get; set; }
        public IEnumerable<comments> comments { get; set; }
        public IEnumerable<AspNetUser> users { get; set; }
    }
}