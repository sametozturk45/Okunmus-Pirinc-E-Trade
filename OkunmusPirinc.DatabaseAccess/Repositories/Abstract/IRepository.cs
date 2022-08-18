using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkunmusPirinc.DatabaseAccess.Repositories.Abstract
{
    public interface IRepository<T>:IDisposable where T : class
    {
        T GetItem(int id);
        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(T item);

    }
}
