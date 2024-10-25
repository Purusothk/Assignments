using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }

        public override string ToString()
        {
            return $"AuthorID: {AuthorID}, Name: {Name}, Nationality: {Nationality}";
        }
    }
}
