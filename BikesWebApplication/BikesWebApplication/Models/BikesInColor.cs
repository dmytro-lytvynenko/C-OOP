using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BikesWebApplication
{
    public partial class BikesInColor
    {
        public BikesInColor()
        {
            Shops = new HashSet<Shop>();
        }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Код товару")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Ціна")]
        public int? Price { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Кількість")]
        public string? Amount { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Модель")]
        public int BikesId { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Номер кольору")]
        public int ColorsId { get; set; }
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Модель")]
        public virtual Bike Bikes { get; set; } = null!;
        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Номер кольору")]
        public virtual Color Colors { get; set; } = null!;
        public virtual ICollection<Shop> Shops { get; set; }
    }
}
