using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    internal class demoException
    {
        class Calculator
        {
            public int Divide(int x, int y)
            {
                return x / y;
            }
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Multiply(int x, int y)
            {
                return x * y;
            }
            public int Subtract(int x, int y)
            {
                return x - y;
            }

            public int DivideA(int x, int y)
            {
                //if (y == 0)
                //    throw new ZeroValueException();
                //if (y == 0)
                //    throw new ZeroValueException("ERROR!!! Value for Y is " + y);
                return x / y;
            }
        }
        internal class ExceptionDemo
        {
            public static void DemoAExceptions()
            {
                Console.WriteLine("\tEnter a no for X");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("\tEnter a no Y");
                int y = int.Parse(Console.ReadLine());
                Calculator c1 = new Calculator();
                int z = c1.Divide(x, y);
                Console.WriteLine("Result in M3 " + z);
            }
        }

    }
}
