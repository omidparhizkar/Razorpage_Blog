 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razorpage_Blog.Models
{
    public class Article
    {
       

        public int Id  { get; set; }
        public string Title  { get; set; }
        public string Picture  { get; set; }
        public string PictureAlt  { get; set; }
        public string PictureTitle  { get; set; }
        public string ShortDescription  { get; set; }
        public string Body  { get; set; }
        public string CreationDate { get; set; }
    }
}
