using Microsoft.EntityFrameworkCore;

namespace LytvynenkoAPIWebApp.Models
{
    public class LytvynenkoAPIContext : DbContext
    {
        public virtual DbSet<Blogger> Bloggers { get; set; }
        public virtual DbSet<BloggerChannel> BloggerChannels { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        public LytvynenkoAPIContext(DbContextOptions<LytvynenkoAPIContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
