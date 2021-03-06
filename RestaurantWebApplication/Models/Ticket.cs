﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantWebApplication.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            Sales = new HashSet<Sales>();
            Date = DateTime.Now;
        }

        public int TicketId { get; set; }
        [DisplayName("Menu Item")]
        public int MenuId { get; set; }
        public DateTime? Date { get; set; }
        [DisplayName("Payment Method")]
        [Required()]
        public string PaymentMethod { get; set; }
        [DisplayName("Staff")]
        public int StaffId { get; set; }
        [Required()]
        [DisplayName("Table Number")]
        public int? TableNumber { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
