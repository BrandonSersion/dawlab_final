using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Movie
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Pic { get; set; }
        public bool Romance { get; set; }
        public bool Comedy { get; set; }
        public bool Drama { get; set; }
        public bool Horror { get; set; }
        public bool Watched { get; set; }
        public bool Skip { get; set; }

        public Movie()
        {
            Romance = false;
            Comedy = false;
            Drama = false;
            Horror = false;
            Watched = false;
            Skip = false;
        }
    }
}

