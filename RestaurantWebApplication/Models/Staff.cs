using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        [Required()]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required()]
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        [Required()]
        public DateTime? DoB { get; set; }
        [Required()]
        public string Address { get; set; }
        [Required()]
        public string Position { get; set; }
        [Required()]
        [DataType(DataType.Date)]
        [DisplayName("Hire Date")]
        public DateTime? HireDate { get; set; }

        public virtual ICollection<Tables> Tables { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
