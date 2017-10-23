using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FlowerBackend.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Flower> Flowers { get; set; }
    }
}