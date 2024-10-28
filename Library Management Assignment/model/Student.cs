using Library_Management_Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Assignment.model
{
    internal class Student: IUser, IBorrower
    {
        public string GetUserType() => "Student";

        public void BorrowBook(string book)
        {
            Console.WriteLine($"{GetUserType()} borrowed the book: {book}");
        }

    }
}
