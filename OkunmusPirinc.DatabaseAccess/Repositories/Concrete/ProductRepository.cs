using OkunmusPirinc.DatabaseAccess.DatabaseAccess;
using OkunmusPirinc.DatabaseAccess.Repositories.Abstract;
using OkunmusPirinc.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkunmusPirinc.DatabaseAccess.Repositories.Concrete
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DBContext context) : base(context)
        {

        }

        public Product GetItemWithCategory(int id)
        {
            return context.Set<Product>().Include(x => x.Category).FirstOrDefault(x=>x.ProductID == id);
        }

        public IEnumerable<Product> ProductsWithCategories()
        {
            return context.Set<Product>().Include(x => x.Category).ToList();
        }
    }
}
