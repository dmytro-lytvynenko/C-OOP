using System;
using System.Collections.Generic;

namespace LytvynenkoWebApplication
{
    public partial class Color
    {
        public Color()
        {
            BikesInColors = new HashSet<BikesInColor>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<BikesInColor> BikesInColors { get; set; }
    }
}
