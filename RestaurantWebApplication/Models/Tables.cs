using System;
using System.Collections.Generic;

namespace RestaurantWebApplication.Models
{
    public partial class Tables
    {
        public int TableNumber { get; set; }
        public string Status { get; set; }
        public int WaitStaff { get; set; }

        public virtual Staff WaitStaffNavigation { get; set; }
    }
}
