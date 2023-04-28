using System;
using System.Collections.Generic;

namespace WebVokzal.WebModels
{
    public partial class User
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PatronomycName { get; set; }
        public long? Phone { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
