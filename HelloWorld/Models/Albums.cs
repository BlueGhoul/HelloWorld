using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    // have to give everything an ID 
    public class Albums
    {
        public int AlbumsID { get; set; }

        public string Title { get; set; }

        // have to put in the ids into this thing
        public int ArtistID { get; set; }

        public Artist Artist { get; set; }

        public int ReviewID { get; set; }

        // need virtual 
        public virtual List<Review> Review { get; set; }
    }
}