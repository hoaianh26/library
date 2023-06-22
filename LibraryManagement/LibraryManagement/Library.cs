using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    // Class representing the library
    public class Library
    {
        private List<Item> items;

        public Library()
        {
            items = new List<Item>();
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine("Item added to the library.");
        }

        public void RemoveItem(Item item)
        {
            if (items.Remove(item))
            {
                Console.WriteLine("Item removed from the library.");
            }
            else
            {
                Console.WriteLine("Item not found in the library.");
            }
        }
    }
}
