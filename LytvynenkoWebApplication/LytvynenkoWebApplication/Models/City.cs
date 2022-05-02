using System;
using System.Collections.Generic;

namespace LytvynenkoWebApplication
{
    public partial class City
    {
        public City()
        {
            Shops = new HashSet<Shop>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string? Population { get; set; }

        public virtual Factory Factory { get; set; } = null!;
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
