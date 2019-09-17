using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    public class Book
    {

        public int id { get; set; }
        [Display(Name ="Title Book Name")]
        [Required]
        [StringLength(maximumLength:20,ErrorMessage ="The Tittle biggest than 20 length")]
        public string Title { get; set; }
        public string  Genre { get; set; }
        
        [DataType(DataType.Currency)]
        [Range(1,1000)]
        public decimal Price { get; set; }
        [Display(Name ="Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

    }
}
