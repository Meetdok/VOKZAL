using System;
using System.Collections.Generic;

namespace WebVokzal.WebModels
{
    public partial class Class
    {
        public Class()
        {
            Trains = new HashSet<Train>();
        }

        public int Id { get; set; }
        public string? Type { get; set; }

        public virtual ICollection<Train> Trains { get; set; }
    }
}
