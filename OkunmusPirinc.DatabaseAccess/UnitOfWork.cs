using OkunmusPirinc.DatabaseAccess.DatabaseAccess;
using OkunmusPirinc.DatabaseAccess.Repositories.Concrete;
using OkunmusPirinc.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkunmusPirinc.DatabaseAccess
{
    public class UnitOfWork : IDisposable
    {
        private readonly DBContext _context;

        private ProductRepository _productRepo;
        private Repository<ProductCategory> _productCategoryRepo;

        public UnitOfWork()
        {
            _context = new DBContext();
        }

        public ProductRepository ProductRepo
        {
            get
            {
                if (_productRepo == null)
                    _productRepo = new ProductRepository(_context);
                return _productRepo;
            }
        }

        public Repository<ProductCategory> ProductCategoryRepo
        {
            get
            {
                if (_productCategoryRepo == null)
                    _productCategoryRepo = new Repository<ProductCategory>(_context);
                return _productCategoryRepo;
            }
        }

        void Save()
        {
            using(var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch(Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
            }
        }

        public void Dispose()
        {
            _productRepo?.Dispose();
            _productCategoryRepo?.Dispose();
            _context?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
