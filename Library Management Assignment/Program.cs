using Library_Management_Assignment.model;
using Library_Management_Assignment.Services;

namespace Library_Management_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            var teacher = new Teacher();
            var librarian = new Librarian();

            var libraryService = new LibraryService();

            // Operations
            libraryService.ExecuteBorrow(student, "Introduction to C#");
            libraryService.ExecuteBorrow(teacher, "Advanced .NET Programming");
            libraryService.ExecuteReserve(teacher, "Database Systems");

            libraryService.ManageInventory(librarian, "New Book on Design Patterns", true);
            libraryService.ManageInventory(librarian, "Old Magazine", false);
        }
    }
}
