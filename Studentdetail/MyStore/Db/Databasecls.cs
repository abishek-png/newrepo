using Microsoft.EntityFrameworkCore;
using MyStore.Model;

namespace MyStore.Db
{
    public class Databasecls:DbContext
    {
        public Databasecls(DbContextOptions<Databasecls>options):base(options) 
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
