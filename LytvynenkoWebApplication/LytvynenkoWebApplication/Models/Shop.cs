using System;
using System.Collections.Generic;

namespace LytvynenkoWebApplication
{
    public partial class Shop
    {
        public int Id { get; set; }
        public int BikesInColorsId { get; set; }
        public string? Name { get; set; }
        public int CityId { get; set; }

        public virtual BikesInColor BikesInColors { get; set; } = null!;
        public virtual City City { get; set; } = null!;
    }
}
