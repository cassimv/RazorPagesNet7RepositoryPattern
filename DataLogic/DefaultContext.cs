using Microsoft.EntityFrameworkCore;

namespace DataLogic
{
    public class DefaultContext : DbContext
    {
        public DefaultContext()
        {

        }
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //This is the connection String - Read from the environment variable.
            //optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        //entities
        public DbSet<Students.Students> Students { get; set; }
    }
}