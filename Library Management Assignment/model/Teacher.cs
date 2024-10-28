using Library_Management_Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Assignment.model
{
    internal class Teacher : IUser, IBorrower, IReserver
    {
        //public string GetUserType() => "Student";

        public string GetUserType() => "Teacher";

        public void BorrowBook(string book)
        {
            Console.WriteLine($"{GetUserType()} borrowed the book: {book}");
        }

        public void ReserveBook(string book) {
            Console.WriteLine($"Book named {book} reserved");
        }
    }
}
