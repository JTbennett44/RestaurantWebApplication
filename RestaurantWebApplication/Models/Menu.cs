using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantWebApplication.Models
{
    public partial class Menu
    {
        public Menu()
        {
            Sales = new HashSet<Sales>();
        }

        public int MenuId { get; set; }
        [Required()]
        public string Item { get; set; }
        public int Category { get; set; }
        public string Description { get; set; }
        [Required()]
        [Range(0, 9999.99)]
        public decimal? Price { get; set; }

        [DisplayName("Category")]
        public virtual Category CategoryNavigation { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
