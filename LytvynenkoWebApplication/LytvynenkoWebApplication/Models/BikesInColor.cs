using System;
using System.Collections.Generic;

namespace LytvynenkoWebApplication
{
    public partial class BikesInColor
    {
        public BikesInColor()
        {
            Shops = new HashSet<Shop>();
        }

        public int Id { get; set; }
        public int? Price { get; set; }
        public string? Amount { get; set; }
        public int BikesId { get; set; }
        public int ColorsId { get; set; }

        public virtual Bike Bikes { get; set; } = null!;
        public virtual Color Colors { get; set; } = null!;
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
