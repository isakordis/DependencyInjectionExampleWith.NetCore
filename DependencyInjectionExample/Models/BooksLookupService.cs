using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    public class BooksLookupService
    {
        public List<string> GetGenres()
        {
            return new List<string>()
        {
            "Fiction",
            "Thriller",
            "Comedy",
            "Autobiography"
        };
        }
    }
}
