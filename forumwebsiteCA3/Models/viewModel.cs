using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace forumwebsiteCA3.Models
{
    public class viewModel
    {
        public IEnumerable<posts> posts { get; set; }
        public IEnumerable<forums> forums { get; set; }
        public IEnumerable<AspNetUser> users { get; set; }
    }
}