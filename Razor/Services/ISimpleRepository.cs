using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Current2.Services
{
    public interface ISimpleRepository<T>
    {
        IEnumerable<T> Entities { get; }

        void AddProduct(T entity);
    }
}
