using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    // Concrete class representing a book
    public class Book : Item
    {
        private string author;
        private int yearOfPublication;
        private string genre;
        private string publishingCompany;

        public Book(string title, string author, int yearOfPublication, string genre, string publishingCompany)
        {
            this.title = title;
            this.author = author;
            this.yearOfPublication = yearOfPublication;
            this.genre = genre;
            this.publishingCompany = publishingCompany;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Year of Publication: " + yearOfPublication);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Publishing Company: " + publishingCompany);
        }
    }
}
