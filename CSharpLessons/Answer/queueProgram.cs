using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class queueProgram
    {
        public static void TestQueue()
        {
            Queue q = new Queue();
            Random r = new Random();
            int x = 0;
            q.Enqueue(25);
            Console.Write(25 + " ");
            for (int i = 0; i < 10; i++)
            {
                x = r.Next(100);
                q.Enqueue(x);
                Console.WriteLine(x + " ");
            }
            Console.WriteLine("");
            int count = q.Count;
            Console.WriteLine("Count=" + count);
            for (int i = 0; i < count; i++)
            {
                Console.Write(q.Peek() + " ");
                // Peek reads the first object in the queue 
                // without removing the object
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Peek =" + count);
            Console.WriteLine("Contains 25-" + q.Contains(25));
            for (int i = 0; i < 9; i++)
            {
                Console.Write(q.Dequeue() + " ");
            }
            Console.WriteLine("");
            count = q.Count;
            Console.WriteLine("Count After Dequeue=" + count);
        }

        class Emp
        {
            public int ID;
            public string Name;
            public double Salary;
        }
        public static void EmpHTDemo()
        {
            Hashtable empTable = new Hashtable();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empTable.Add(e.ID, e);
            }
            Console.WriteLine("Count " + empTable.Count);
            Console.WriteLine("ContainsKey(5) " + empTable.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empTable.ContainsKey(15));
        }

        // sorted list is a dictionary
        public static void EmpDictionaryDemo()
        {
            Dictionary<int, Emp> empMap = new Dictionary<int, Emp>();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empMap.Add(e.ID, e);
            }
            Emp e1 = new Emp() { ID = 12345, Name = "Venkat", Salary = 1000000 };
            empMap.Add(15, e1);
            empMap.Add(16, e1);

            Console.WriteLine("Count " + empMap.Count);
            Console.WriteLine("ContainsKey(5) " + empMap.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empMap.ContainsKey(15));
        }

        // sorted based on keys if keys are alphabet then hashcode
        // Hashcode : when a object is stored in heap , it give a unique number generates at runtime. That number is Hashcode
        public static void TestSortedListA()
        {
            SortedList<int, int> slist = new SortedList<int, int>();
            int count = slist.Count;
            Console.WriteLine("Count " + count);
            Console.WriteLine(" Capacity " + slist.Capacity);
            Random r1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = r1.Next(100);
                if (!slist.ContainsKey(x))
                    slist.Add(x, x * 55);
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Count " + slist.Count);
            Console.WriteLine(" Capacity " + slist.Capacity);

            foreach (var i in slist)
            {
                Console.WriteLine(i.Key + "," + i.Value);
            }
        }

        // VERY VERY IMPORTANT
        public static void TestSortedListOfEmp()
        {
            SortedList<int, Emp> empsortlist = new SortedList<int, Emp>();
            Random r1 = new Random();
            Emp e1 = new Emp() { ID = r1.Next(100), Name = "John", Salary = r1.NextDouble() * 5000 };
            Emp e2 = new Emp() { ID = r1.Next(100), Name = "Sam", Salary = r1.NextDouble() * 5000 };
            Emp e3 = new Emp() { ID = r1.Next(100), Name = "Ajith", Salary = r1.NextDouble() * 5000 };
            Emp e4 = new Emp() { ID = r1.Next(100), Name = "Ellango", Salary = r1.NextDouble() * 5000 };
            Emp e5 = new Emp() { ID = r1.Next(100), Name = "Basker", Salary = r1.NextDouble() * 5000 };
            if (!empsortlist.ContainsKey(e1.ID))
                empsortlist.Add(e1.ID, e1);
            if (!empsortlist.ContainsKey(e2.ID))
                empsortlist.Add(e2.ID, e2);
            if (!empsortlist.ContainsKey(e3.ID))
                empsortlist.Add(e3.ID, e3);
            if (!empsortlist.ContainsKey(e4.ID))
                empsortlist.Add(e4.ID, e4);
            if (!empsortlist.ContainsKey(e5.ID))
                empsortlist.Add(e5.ID, e5);

            Console.WriteLine("Count " + empsortlist.Count);
            Console.WriteLine(" Capacity " + empsortlist.Capacity); //capacity default value is 4 , then count exceeds 4 , it doubles and give 8 // if capacity is 9 then capcity is 16

            foreach (var emp in empsortlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
            var orderedlist = empsortlist.OrderBy(tkey => tkey.Value.Name);// tskey is just a variable , we can use even 'x'
            foreach (var emp in orderedlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
            var desclist = empsortlist.OrderByDescending(tkey => tkey.Value.Salary);
            foreach (var emp in desclist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Salary);
            }
        }
        // 
        internal class WorkingwithClass
        {
            public static void TestOne()
            {
                Object objectOne = new object();
                Console.WriteLine($"ToString: {objectOne.ToString()}");
                Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
                Type typeOne = objectOne.GetType();
                Console.WriteLine($"Type: {typeOne.FullName}");

                String stringData = "WorldCup 2023";
                Console.WriteLine($"ToString: {stringData.ToString()}");
                Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
                Type typeTwo = stringData.GetType();
                Console.WriteLine($"Type: {typeTwo.FullName}");
            }
            public static void TestTwo()
            {
                Emp empOne = new Emp();
                empOne.ID = 1001;
                int x = empOne.ID;
                Console.WriteLine(x);
                Emp empTwo = new Emp();
                empOne.ID = 1001;
                int y = empTwo.ID;
                Emp empThree = empOne;
                empOne.ID = 1003;
                bool flag = (x.Equals( y) );
                Console.WriteLine(flag);
                flag = empOne.Equals( empThree);
                Console.WriteLine(flag);
                Console.WriteLine(empOne.GetHashCode());
                Console.WriteLine(empTwo.GetHashCode());
                Console.WriteLine(empThree.GetHashCode());
            }
            class Box
            {
                List<int> noList = new List<int>();
                public void FillList(int from, int to)
                {
                    int i = 0;
                    for (i = from; i < to; i++)
                    {
                        noList.Add(i);
                    }
                }
                public List<int> GetList()
                {
                    return noList;
                }

            }
            class BoxA<T>
            {
                List<T> myList = new List<T>();
                public void FillList(T data)
                {
                    myList.Add(data);
                }
                public List<T> GetList()
                {
                    return myList;
                }
                public static void TestA()
                {
                    Box b1 = new Box();
                    b1.FillList(100, 110);
                    List<int> l = b1.GetList();
                    foreach (int x in l)
                    {
                        Console.WriteLine(x);
                    }
                }
                public static void TestB()
                {
                    BoxA<string> b1 = new BoxA<string>();
                    b1.FillList("Hello");
                    List<string> l = b1.GetList();
                    foreach (string s in l)
                        Console.WriteLine(s);

                    BoxA<float> b2 = new BoxA<float>();
                    b2.FillList(55.24f);
                    List<float> flist = b2.GetList();
                    foreach (float f in flist)
                        Console.WriteLine(f);
                }
            }
        }

        // template replce with another datatype 
        
       

    }
}
