using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BikesWebApplication
{
    public partial class Bike
    {
        public Bike()
        {
            BikesInColors = new HashSet<BikesInColor>();
        }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Номер моделі")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва моделі")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Номер розміру")]
        public int SizeId { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Номер фабрики")]
        public int FactoryId { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Номер фабрики")]
        public virtual Factory Factory { get; set; } = null!;
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Номер розміру")]
        public virtual Size Size { get; set; } = null!;
        public virtual ICollection<BikesInColor> BikesInColors { get; set; }
    }
}
