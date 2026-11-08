using Microsoft.EntityFrameworkCore;
using MeMe.API.Models;

namespace MeMe.API.Data
{
    public class MeMeDbContext : DbContext
    {
        public MeMeDbContext(DbContextOptions<MeMeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}