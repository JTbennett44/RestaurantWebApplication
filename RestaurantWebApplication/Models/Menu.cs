using System;
using System.Collections.Generic;

namespace RestaurantWebApplication.Models
{
    public partial class Menu
    {
        public Menu()
        {
            Sales = new HashSet<Sales>();
        }

        public int MenuId { get; set; }
        public string Item { get; set; }
        public int Category { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public virtual Category CategoryNavigation { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
