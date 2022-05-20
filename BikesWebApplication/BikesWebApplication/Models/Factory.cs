using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BikesWebApplication
{
    public partial class Factory
    {
        public Factory()
        {
            Bikes = new HashSet<Bike>();
        }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Фабрика")]
        public int Id { get; set; }
        [Display(Name = "Код міста")]
        public int CityId { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва бренду")]
        public string? Name { get; set; }

        [Display(Name = "Код міста")]
        public virtual City City { get; set; } = null!;
        public virtual ICollection<Bike> Bikes { get; set; }
    }
}
