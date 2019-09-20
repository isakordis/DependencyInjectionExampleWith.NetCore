using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    public interface IBookDI<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        void Add(Book book);
    }
}
