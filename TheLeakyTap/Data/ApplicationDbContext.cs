using System;
using TheLeakyTap.Models;
using Microsoft.EntityFrameworkCore;

namespace TheLeakyTap.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Booking> Bookings { get; set; }
    }
}
