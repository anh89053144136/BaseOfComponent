using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BaseOfComponent
{
    public class ElementContext : DbContext
    {
        public ElementContext()
        {
            Database.SetInitializer<ElementContext>(null);
        }

        public DbSet<Element> Elements { get; set; }
        public DbSet<Relation> Relations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
