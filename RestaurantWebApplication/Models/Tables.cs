using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantWebApplication.Models
{
    public partial class Tables
    {
        public int TablesID { get; set; }
        [DisplayName("Table Number")]
        [Required()]
        [Range(0,100)]
        public int Number { get; set; }
        [Required()]
        public string Status { get; set; }
        [DisplayName("Waiter")]
        public int WaitStaff { get; set; }

        [DisplayName("Waiter")]
        public virtual Staff WaitStaffNavigation { get; set; }
    }
}
