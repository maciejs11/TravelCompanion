using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.BlogPosts
{
    public class BlogPost
    {
        public Guid BlogPostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }   
        public string Url { get; set; }
        public DateTime AdvertDate { get; set; } = DateTime.Now;       
    }
}
