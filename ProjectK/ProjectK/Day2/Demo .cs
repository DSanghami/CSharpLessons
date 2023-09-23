using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ProjectK.Day2
{
    internal class Demo
    {
        static int y = 200;
        //int x = 100;

        public static void FirstMethod() {
          //  int x = 200;
            int y = 500;
            Console.WriteLine(y);
            Console.WriteLine(Demo.y);
        }
    }
    


}*/

namespace New1.Day
{
    internal class Demo
    { 
        internal class Box
        {
            public static int height;
            public  int width;

            public int GetHeight() { return height; }
        }
        internal class TestBox
        {
            public static void TestOne()
            {
                Box.height = 100;

                // Box.width = 200;
                Box firstbox = new Box();
                Box secondBox = new Box();
                firstbox.width = 12345;
                secondBox.width = 94839;

                Console.WriteLine($"firstbox= {firstbox.width}, {firstbox.GetHeight()}"); // non-static method
                Console.WriteLine($"secondbox= {firstbox.width}, {Box.height}"); // static variable
            }
        }
    }
}
 