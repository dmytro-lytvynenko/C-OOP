using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BikesWebApplication
{
    public partial class City
    {
        public City()
        {
            Factories = new HashSet<Factory>();
            Shops = new HashSet<Shop>();
        }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Код міста")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва міста")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Країна")]
        public string? Country { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Населення")]
        public string? Population { get; set; }

        public virtual ICollection<Factory> Factories { get; set; }
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
