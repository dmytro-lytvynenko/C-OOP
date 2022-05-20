using System.ComponentModel.DataAnnotations;

namespace LytvynenkoAPIWebApp.Models
{
    public class Channel
    {
        public Channel()
        {
            BloggerChannels = new List<BloggerChannel>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Це поле не повинно бути порожнім")]
        [Display(Name = "Назва")]
        public string Title { get; set; }
        [Display(Name = "Опис")]
        public virtual Category Category { get; set; }
        public virtual ICollection<BloggerChannel> BloggerChannels { get; set; }
    }
}
