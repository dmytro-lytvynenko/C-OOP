using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BikesWebApplication
{
    public partial class Shop
    {
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Номер магазина")]
        public int Id { get; set; }
        [Display(Name = "Код велосипеда")]
        public int BikesInColorsId { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва магазина")]
        public string? Name { get; set; }
        [Display(Name = "Код міста")]
        public int CityId { get; set; }

        [Display(Name = "Код велосипеда")]
        public virtual BikesInColor BikesInColors { get; set; } = null!;
        [Display(Name = "Код міста")]
        public virtual City City { get; set; } = null!;
    }
}
