using Microsoft.EntityFrameworkCore;
using TheLeakyTap.Models;

namespace TheLeakyTap.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Booking> Bookings { get; set; }
    }
}
