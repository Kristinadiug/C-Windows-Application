using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class Restaurant
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public Restaurant(string name)
        {
            Name = name;
        }
        public Restaurant()
        {
            Name = "Unknown";
        }
    }
}
