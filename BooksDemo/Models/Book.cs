using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDemo.Models
{
    public class Book
    {

        public int id { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public int CountryId { get; set; }
        public Country Countries { get; set; }

        public override string ToString()
        {
            return $"{id} {Author} {Price} {Title}";
        }

    }
}
