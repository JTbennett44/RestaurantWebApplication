using System;
using System.Collections.Generic;

namespace RestaurantWebApplication.Models
{
    public partial class Sales
    {
        public int SaleId { get; set; }
        public int MenuId { get; set; }
        public int TicketId { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
