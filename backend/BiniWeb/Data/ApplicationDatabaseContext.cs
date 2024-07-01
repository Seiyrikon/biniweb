using BiniWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BiniWeb.Data
{
    public class ApplicationDatabaseContext : DbContext
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Member> Members { get; set; }
    }
}