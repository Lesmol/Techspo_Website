using Microsoft.EntityFrameworkCore;
using Work_Integrated_Learning.Models;

namespace Work_Integrated_Learning.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Presenters> Presenters { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
