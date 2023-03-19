using System;
using TheLeakyTap.Models;
using Microsoft.EntityFrameworkCore;

namespace TheLeakyTap.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Booking> Bookings { get; set; }
    }
}
