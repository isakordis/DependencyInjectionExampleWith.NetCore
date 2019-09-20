using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    public class BookDI:IBookDI<Book>
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();

        }
        IEnumerable<Book> IBookDI<Book>.GetAll()
        {
            return new List<Book>()
            {
                new Book(){}
            };
        }
    }
}
