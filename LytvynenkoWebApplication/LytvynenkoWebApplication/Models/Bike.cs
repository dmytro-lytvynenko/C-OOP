using System;
using System.Collections.Generic;

namespace LytvynenkoWebApplication
{
    public partial class Bike
    {
        public Bike()
        {
            BikesInColors = new HashSet<BikesInColor>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int SizeId { get; set; }
        public int FactoryId { get; set; }

        public virtual Factory Factory { get; set; } = null!;
        public virtual Size Size { get; set; } = null!;
        public virtual ICollection<BikesInColor> BikesInColors { get; set; }
    }
}
