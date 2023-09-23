using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class StreamLesson
    {
        public static void TestOne()
        {
            Char ch;
            Console.WriteLine("Press a key followed by enter"); // output stream
            int x = Console.Read(); // input stream 
            ch = (char)x;
            Console.WriteLine("\n" + x + "Your Key is" + ch);
        }

        public static void TestTwo() {
            Char ch = ' ';
            Console.WriteLine("Press a key q to exit: ");
            while (ch != 'q')
            {
                ch = (char)Console.Read();
                Console.WriteLine("Your Key is" + ch);
            }
        }
        public static void TestThree()
        {
            Console.WriteLine("Enter a sentence");
            string? str = Console.ReadLine(); // value typets cannot be null because if we dont assign any value then it contains 0.
                                              // Any operation with null is null like dive with null, multiply with null
                                              // '?'  Nullable , diff b/w nullable int and int are 
            Console.Out.WriteLine(" " + str);
        }
        public static void TestNullabletype()
        {
            int? x = 0;
            x = null; 
            if(x.HasValue) {
                Console.WriteLine(x.Value);
            }
            else 
                Console.WriteLine(x.GetValueOrDefault());
        }
    }
}
