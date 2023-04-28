using System;
using System.Collections.Generic;

namespace WebVokzal.WebModels
{
    public partial class Train
    {
        public Train()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public long? Seats { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
