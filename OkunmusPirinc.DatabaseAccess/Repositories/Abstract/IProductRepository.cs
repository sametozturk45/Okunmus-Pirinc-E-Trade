using OkunmusPirinc.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkunmusPirinc.DatabaseAccess.Repositories.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> ProductsWithCategories();
        Product GetItemWithCategory(int id);
    }
}
