using System;
using System.Collections.Generic;

namespace WebVokzal.WebModels
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Departure { get; set; }
        public string? Arrive { get; set; }
        public int? UserId { get; set; }
        public int? TrainId { get; set; }
        public long? Seat { get; set; }

        public virtual Train? Train { get; set; }
        public virtual User? User { get; set; }
    }
}
