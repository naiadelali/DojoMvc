using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoMvc.Dao
{
    public class DojoContext : DbContext
    {
        public DbSet<ProductDao> Produto { get; set; }
        public DbSet<UnitMeasureDao> UnitMeasute { get; set; }

        public DojoContext()
            : base("DbDojo3")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            CreateDatabaseIfNotExists<DbContext> context;

            base.OnModelCreating(modelBuilder);

        }
    }
}
