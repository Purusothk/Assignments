using Library_Management_Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Assignment.model
{
    internal class Librarian: IInventoryManager
    {
        public string GetUserType() => "Librarian";


        public void AddBook(string book)
        {
            Console.WriteLine($"{book} has been added");
        }

        public void RemoveBook(string book)
        {
            Console.WriteLine($"{book} has been removed");
        }
    }
}
