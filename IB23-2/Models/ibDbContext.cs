using System.Data.Entity;

namespace IB23_2.Models
{
    public class IbDbContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Code> Codes { get; set; }
        public DbSet<Cycles> Cycles { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Person> People { get; set; }
    }
}