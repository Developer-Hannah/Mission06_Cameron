using Microsoft.EntityFrameworkCore;

namespace Mission06_Cameron.Models
{
    public class CollectionFormContext : DbContext
    {
        public CollectionFormContext(DbContextOptions<CollectionFormContext> options) : base (options) //Constructor
        {
        }

        public DbSet<Form> Forms { get; set; }
    }
}