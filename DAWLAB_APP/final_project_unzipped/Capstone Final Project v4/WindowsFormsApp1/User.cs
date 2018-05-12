using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int horror { get; set; }
        public int romance { get; set; }
        public int comedy { get; set; }
        public int drama { get; set; }

        public User()
        {
            firstName = "";
            lastName = "";
            horror = 0;
            romance = 0;
            comedy = 0;
            drama = 0;
        }
    }
}
