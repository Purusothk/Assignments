using Library_Management_Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Assignment.Services
{
    internal class LibraryService
    {
        public void ExecuteBorrow(IBorrower borrower, string book)
        {
            borrower.BorrowBook(book);
        }

        public void ExecuteReserve(IReserver reserver, string book)
        {
            reserver.ReserveBook(book);
        }

        public void ManageInventory(IInventoryManager manager, string book, bool isAdding)
        {
            if (isAdding)
                manager.AddBook(book);
            else
                manager.RemoveBook(book);
        }
    }
}
