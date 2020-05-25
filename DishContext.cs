using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class DishContext: DbContext
    {
        public DishContext()
        : base("DefaultConnection")
        { }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
