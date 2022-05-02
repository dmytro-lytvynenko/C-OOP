using System;
using System.Collections.Generic;

namespace LytvynenkoWebApplication
{
    public partial class Factory
    {
        public Factory()
        {
            Bikes = new HashSet<Bike>();
        }

        public int Id { get; set; }
        public int CityId { get; set; }
        public string? Name { get; set; }

        public virtual City IdNavigation { get; set; } = null!;
        public virtual ICollection<Bike> Bikes { get; set; }
    }
}
