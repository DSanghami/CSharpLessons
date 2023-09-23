using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryA
{ // it cannot run because public static void is missing and it is class library not console application.
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public  int Multiply(int x, int y) { 
            return x * y;
        }
        public int Divide(int x, int y) {  return x / y; }

    }
}
