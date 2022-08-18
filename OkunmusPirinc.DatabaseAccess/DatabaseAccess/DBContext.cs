using OkunmusPirinc.DatabaseAccess.DatabaseInitializer;
using OkunmusPirinc.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkunmusPirinc.DatabaseAccess.DatabaseAccess
{
    public class DBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DBContext():base("OkunmusPirincDB")
        {
            Database.SetInitializer(new OkunmusInitializer());
        }
    }
}
