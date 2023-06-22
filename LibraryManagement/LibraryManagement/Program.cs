using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    // Class representing the program
    public class 

    {
        private List<Item> items;

        public Program()
        {
            items = new List<Item>();
        }

        public void DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Library Management System!");
            Console.WriteLine("-----------------------------------------");
            Console.ResetColor();
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Add a story");
            Console.WriteLine("3. Remove an item");
            Console.WriteLine("4. Display all items");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            ExecuteChoice(choice);
        }

        public void ExecuteChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Adding a Book");
                    Console.WriteLine("-------------");
                    Console.ResetColor();
                    Console.Write("Enter the book title: ");
                    string bookTitle = Console.ReadLine();
                    Console.Write("Enter the author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter the year of publication: ");
                    int yearOfPublication = int.Parse(Console.ReadLine());
                    Console.Write("Enter the genre: ");
                    string genre = Console.ReadLine();
                    Console.Write("Enter the publishing company: ");
                    string publishingCompany = Console.ReadLine();
                    Book book = new Book(bookTitle, author, yearOfPublication, genre, publishingCompany);
                    AddItem(book);
                    Console.WriteLine("\nBook added to the library.");
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Adding a Story");
                    Console.WriteLine("--------------");
                    Console.ResetColor();
                    Console.Write("Enter the story title: ");
                    string storyTitle = Console.ReadLine();
                    Console.Write("Enter the editor: ");
                    string editor = Console.ReadLine();
                    Console.Write("Enter the year of publication: ");
                    yearOfPublication = int.Parse(Console.ReadLine());
                    Console.Write("Enter the genre: ");
                    genre = Console.ReadLine();
                    Console.Write("Enter the publishing company: ");
                    publishingCompany = Console.ReadLine();
                    Story story = new Story(storyTitle, editor, yearOfPublication, genre, publishingCompany);
                    AddItem(story);
                    Console.WriteLine("\nStory added to the library.");
                    break;
                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Removing an Item");
                    Console.WriteLine("----------------");
                    Console.ResetColor();
                    Console.Write("Enter the title of the item to remove: ");
                    string titleToRemove = Console.ReadLine();
                    Item itemToRemove = GetItemByTitle(titleToRemove);
                    if (itemToRemove != null)
                    {
                        RemoveItem(itemToRemove);
                        Console.WriteLine("\nItem removed from the library.");
                    }
                    else
                    {
                        Console.WriteLine("\nItem not found in the library.");
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Displaying all Items");
                    Console.WriteLine("--------------------");
                    Console.ResetColor();
                    DisplayAllItems();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Exiting the program.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            DisplayMenu();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public Item GetItemByTitle(string title)
        {
            return items.Find(item => item.GetTitle() == title);
        }

        public void DisplayAllItems()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Items in the library:");
            Console.ResetColor();
            foreach (Item item in items)
            {
                item.PrintInfo();
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.DisplayMenu();
        }
    }
}