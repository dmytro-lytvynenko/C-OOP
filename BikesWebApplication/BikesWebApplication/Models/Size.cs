using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BikesWebApplication
{
    public partial class Size
    {
        public Size()
        {
            Bikes = new HashSet<Bike>();
        }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Порядковий номер")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва розміру")]
        public string? Name { get; set; }

        public virtual ICollection<Bike> Bikes { get; set; }
    }
}
