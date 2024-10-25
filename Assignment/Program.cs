
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Xml.Serialization;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      Create a Book and Author class with suitable properties and Hardcoded with Minimum 5 data
            //      for both the classes and covert into Json and XML Format  and store that data in Local Disk using File  concept.
            //      Read the Json and XML data and display the same in console App
            //      has context menuConsole.WriteLine("Hello, World!");



            string booksFilePathXml = "C:\\Users\\n.k.purusothaman\\Desktop\\dev\\tech\\domain training\\Day4\\books.xml";
            string authorsFilePathXml = "C:\\Users\\n.k.purusothaman\\Desktop\\dev\\tech\\domain training\\Day4\\authors.xml";
            string booksFilePathJson = "C:\\Users\\n.k.purusothaman\\Desktop\\dev\\tech\\domain training\\Day4\\books.json";
            string authorsFilePathJson = "C:\\Users\\n.k.purusothaman\\Desktop\\dev\\tech\\domain training\\Day4\\authors.json";




            var authors = new List<Author>
            {
                new Author { AuthorID = 1, Name = "J.K. Rowling", Nationality = "British" },
                new Author { AuthorID = 2, Name = "George R.R. Martin", Nationality = "American" },
                new Author { AuthorID = 3, Name = "Agatha Christie", Nationality = "British" },
                new Author { AuthorID = 4, Name = "Mark Twain", Nationality = "American" },
                new Author { AuthorID = 5, Name = "J.R.R. Tolkien", Nationality = "British" }
            };

            var books = new List<Book>
            {
                new Book { BookID = 1, Title = "Harry Potter", AuthorID = 1, Genre = "Fantasy", Price = 29.99 },
                new Book { BookID = 2, Title = "Game of Thrones", AuthorID = 2, Genre = "Fantasy", Price = 39.99 },
                new Book { BookID = 3, Title = "Murder on the Orient Express", AuthorID = 3, Genre = "Mystery", Price = 19.99 },
                new Book { BookID = 4, Title = "The Adventures of Tom Sawyer", AuthorID = 4, Genre = "Adventure", Price = 9.99 },
                new Book { BookID = 5, Title = "The Hobbit", AuthorID = 5, Genre = "Fantasy", Price = 24.99 }
            };



            SerializeToXml(books, booksFilePathXml);
            SerializeToXml(authors, authorsFilePathXml);

            // Serialize data to JSON
            SerializeToJson(books, booksFilePathJson);
            SerializeToJson(authors, authorsFilePathJson);

            // Deserialize and display data from XML and JSON files
            Console.WriteLine("Books from XML:");
            var deserializedBooksXml = DeserializeFromXml<List<Book>>(booksFilePathXml);
            deserializedBooksXml.ForEach(b => Console.WriteLine(b));

            Console.WriteLine("\nAuthors from XML:");
            var deserializedAuthorsXml = DeserializeFromXml<List<Author>>(authorsFilePathXml);
            deserializedAuthorsXml.ForEach(a => Console.WriteLine(a));

            Console.WriteLine("\nBooks from JSON:");
            var deserializedBooksJson = DeserializeFromJson<List<Book>>(booksFilePathJson);
            deserializedBooksJson.ForEach(b => Console.WriteLine(b));

            Console.WriteLine("\nAuthors from JSON:");
            var deserializedAuthorsJson = DeserializeFromJson<List<Author>>(authorsFilePathJson);
            deserializedAuthorsJson.ForEach(a => Console.WriteLine(a));



            //    create a Customer class with the below properties
            //    public string Name { get; set; }
            //    public string Email { get; set; }
            //    public string PhoneNumber { get; set; }
            //    public DateTime DateOfBirth { get; set; }
            //    create a separate class to validate PhoneNumber, Email, DOB using some function which should return bool (true if valid ,False if invalid)

            CustomerValidation cv = new CustomerValidation();
            cv.run();
        }

        // Serialization to XML
        static void SerializeToXml<T>(T data, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using FileStream fs = new FileStream(filePath, FileMode.Create);
            serializer.Serialize(fs, data);
            Console.WriteLine($"{filePath} created successfully.");
        }

        // Serialization to JSON
        static void SerializeToJson<T>(T data, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine($"{filePath} created successfully.");
        }

        // Deserialization from XML
        static T DeserializeFromXml<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using FileStream fs = new FileStream(filePath, FileMode.Open);
            return (T)serializer.Deserialize(fs);
        }

        // Deserialization from JSON
        static T DeserializeFromJson<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}

    //XmlSerializer bookSerializer = new XmlSerializer(typeof(Book));
    //XmlSerializer auhtorSerializer = new XmlSerializer(typeof(Author));



    //using (FileStream fs = new FileStream(filePath, FileMode.Create))
    //    {
    //    foreach (Book b in books)
    //    {
    //        bookSerializer.Serialize(fs, b);
    //        Console.WriteLine("Serialized Books to XML.");
    //    }
    //}





    //using (FileStream fs1 = new FileStream(filePath1, FileMode.Create))
    //{
    //    foreach (Author a in authors)
    //    {
    //        bookSerializer.Serialize(fs1, a);
    //        Console.WriteLine("Serialized product to XML.");
    //    }
    //}



//    }
//}
