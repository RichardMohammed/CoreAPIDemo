using Microsoft.EntityFrameworkCore;

namespace CoreAPIDemo.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext( DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<PatientModel> Patient { get; set; }
        public DbSet<SurgeryModel> Surgery { get; set; }
    }
}
