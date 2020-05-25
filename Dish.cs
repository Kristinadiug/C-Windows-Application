using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class Dish
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Temperature { get; set; }
        public int Price { get; set; }
        

        public int Restaurant_Id { set; get; }

        public Dish() { }
        public Dish(string _name, string _weight, string _temperature, string _price, int res_id)
        {
            Name = _name;
            Weight = Convert.ToInt32(_weight);
            Temperature = Convert.ToInt32(_temperature);
            Price = Convert.ToInt32(_price);
            Restaurant_Id = res_id;
        }

        public override string ToString()
        {
            return $"{Name} {Weight} {Temperature} {Price}";
        }
    }
}
