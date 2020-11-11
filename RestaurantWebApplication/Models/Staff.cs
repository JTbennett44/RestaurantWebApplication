using System;
using System.Collections.Generic;

namespace RestaurantWebApplication.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Tables = new HashSet<Tables>();
            Ticket = new HashSet<Ticket>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? DoB { get; set; }
        public string Address { get; set; }
        public string SecurityLevel { get; set; }
        public DateTime? HireDate { get; set; }

        public virtual ICollection<Tables> Tables { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
