using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"BookID: {BookID}, Title: {Title}, AuthorID: {AuthorID}, Genre: {Genre}, Price: {Price}";
        }
    }
}
