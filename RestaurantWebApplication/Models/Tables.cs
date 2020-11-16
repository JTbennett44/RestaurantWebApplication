using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RestaurantWebApplication.Models
{
    public partial class Tables
    {
        public int TablesID { get; set; }
        [DisplayName("Table Number")]
        public int Number { get; set; }
        public string Status { get; set; }
        [DisplayName("Waiter")]
        public int WaitStaff { get; set; }

        [DisplayName("Waiter")]
        public virtual Staff WaitStaffNavigation { get; set; }
    }
}
