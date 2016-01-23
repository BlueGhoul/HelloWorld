using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }

        public virtual Albums Album { get; set; }

        public string Contents { get; set; }

        public string ReviewEmail { get; set; }
    }
}