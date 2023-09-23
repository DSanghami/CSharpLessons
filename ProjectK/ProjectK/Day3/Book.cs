using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectK.Day3
{
    internal abstract class Book
    {
        public Book() {
            Console.WriteLine("Book Constructor");
        }
        public abstract void OpenBook();
    }
}
