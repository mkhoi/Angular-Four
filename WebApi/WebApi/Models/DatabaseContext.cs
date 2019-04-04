using System.Data.Entity;

namespace WebApi.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(): base("name=conn")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}