using System;
using System.Collections.Generic;

namespace RestaurantWebApplication.Models
{
    public partial class Category
    {
        public Category()
        {
            Menu = new HashSet<Menu>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Menu> Menu { get; set; }
    }
}
