using System;
using System.Collections.Generic;

namespace RestaurantWebApplication.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            Sales = new HashSet<Sales>();
        }

        public int TicketId { get; set; }
        public DateTime? Date { get; set; }
        public string PaymentMethod { get; set; }
        public int StaffId { get; set; }
        public int? TableNumber { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
