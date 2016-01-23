using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string Name { get; set; }

        public List<Albums> Albums { get; set; }
    }
}