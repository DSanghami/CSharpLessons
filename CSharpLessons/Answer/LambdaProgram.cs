using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class LambdaProgram
    {

public static void DemoA()

        {

            Func<int, int> foo = x => x / 2;//Last int parameter is the result 1st is the input

            int i = 100;

            int result = foo(i);

            Console.WriteLine(result);



        }

        public static void DemoB()

        {

            Func<int> foo = () => 100; //has return type but no parameter

            int result = foo();

            Console.WriteLine(result);

        }



        public static void DemoC()

        {

            Func<double, double, double> callme = (x, y) => (x + y) / 2;

            int v1 = 101;

            int v2 = 10;

            double result = callme(v1, v2);

            Console.WriteLine(result);

        }

        public static void DemoD()

        {

            //smaller can be coverted to big that is int to long is possible but the vice versa is not possible.

            Func<int, double> foo = x => x / 2;

            int v1 = 101;

            double result = foo(v1);

            Console.WriteLine(result);

        }
        static double Dotrans(Func<int,int,double> foo)
        {
            return foo(50, 5);
        }
        static void TestDoTrans()
        {
            Func<int,int,double> Multiply = (x,y) => x * y;
            double d = Dotrans(Multiply);
            Console.WriteLine(d);
            Func<int, int, double> Add = (x,y) => x + y;
            d = Dotrans(Add);
            Console.WriteLine(d);
            Func<int, int, double> Divide = (x, y) =>
            {
                if (y == 0) y = 1; return x / y;
            };
            double d1 = Dotrans(Divide);
            Console.WriteLine( d1);
        }
    }
}
