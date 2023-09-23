using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class Answer
    {
        public static void QuestionOne()
        {
            byte byteOne = 1;
            sbyte sbyteOne = 1;
            short shortOne = 1;
            int intOne = 1;
            long longOne = 1;
            float floatOne = 1.543f;
            double doubleOne = 2345.76534d;
            decimal decimalOne = 627637263.36263726372M;
            char charOne = 'A';
            bool boolOne = true;
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MaxValue);
        }
    }
}
