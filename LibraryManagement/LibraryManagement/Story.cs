using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    // Concrete class representing a story
    public class Story : Item
    {
        private string editor;
        private int yearOfPublication;
        private string genre;
        private string publishingCompany;

        public Story(string title, string editor, int yearOfPublication, string genre, string publishingCompany)
        {
            this.title = title;
            this.editor = editor;
            this.yearOfPublication = yearOfPublication;
            this.genre = genre;
            this.publishingCompany = publishingCompany;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Editor: " + editor);
            Console.WriteLine("Year of Publication: " + yearOfPublication);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Publishing Company: " + publishingCompany);
        }
    }
}
