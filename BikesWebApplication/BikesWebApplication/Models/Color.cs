using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BikesWebApplication
{
    public partial class Color
    {
        public Color()
        {
            BikesInColors = new HashSet<BikesInColor>();
        }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Номер кольору")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва кольору")]
        public string? Name { get; set; }

        public virtual ICollection<BikesInColor> BikesInColors { get; set; }
    }
}
