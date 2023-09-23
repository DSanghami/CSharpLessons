using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class SetProgram
    {
        public static void TestGenericSortedSetInt()
        {
            SortedSet<int> alist = new SortedSet<int>();
            int count = alist.Count;
            Console.WriteLine("Count " + count);
            alist.Add(10);
            alist.Add(10);
            alist.Add(10);
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
                alist.Add(x);
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + alist.Count);
            foreach (int i in alist)
                Console.Write(i + ",");
        }
        public static void SetStringDemo()
        {
            HashSet<String> stringSet = new HashSet<String>();
            stringSet.Add("Chennai");
            stringSet.Add("Salem");
            stringSet.Add("Erode");
            stringSet.Add("Tirupur");
            stringSet.Add("Kovai");
            stringSet.Add("Chennai");
            stringSet.Add("Trichy");
            stringSet.Add("Madurai");
            stringSet.Add("Nellai");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add("Trichy");
            stringSet.Add(null);
            stringSet.Add(null);
            Console.WriteLine($"Count:{stringSet.Count}");
            foreach (var item in stringSet)
            {
                if (item != null)
                    Console.WriteLine(item);
                else
                    Console.WriteLine("NULL");
            }

        }
    }
}
