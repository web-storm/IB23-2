using System.Data.Entity;

namespace IB23_2.Models
{
    public class IbDbContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Code> Codes { get; set; }
    }
}