using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Assignment.Interfaces
{
    internal interface IInventoryManager
    {
        void AddBook(string book);
        void RemoveBook(string book);
    }
}
