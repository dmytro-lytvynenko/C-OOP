using System;
using System.Collections.Generic;

namespace LytvynenkoWebApplication
{
    public partial class Size
    {
        public Size()
        {
            Bikes = new HashSet<Bike>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Bike> Bikes { get; set; }
    }
}
