using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    // Abstract base class for items in the library
    public abstract class Item
    {
        protected string title;

        public string GetTitle()
        {
            return title;
        }

        public abstract void PrintInfo();
    }
}
