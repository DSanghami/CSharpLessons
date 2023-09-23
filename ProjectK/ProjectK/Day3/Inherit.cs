using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectK.Day3
{
    
        
    internal class Box
        {
            public int Height;
            public int Length;
            public int Width;

            public Box(int x)
            {
                Console.WriteLine("Box Object Created");
            }
            public void Open()
            {
                Console.WriteLine("Box is Open");
            }
            public void Close()
            {
                Console.WriteLine("Box is Closed");
            }
            public override string ToString(){ 
                return $"Height:{Height}, Length:{Length}, Width:{Width}";  
            }
        }
        internal class WoodenBox : Box {
        public WoodenBox():base(1)
        {
            Console.WriteLine("Woodenbox Constructor");
        }
        public WoodenBox(int x):base(x)
        {
            Console.WriteLine("Woodenbox Constructor");
        }
        public WoodenBox(int x, int y):base(x)
        {
            Console.WriteLine("Woodenbox Constructor");
        }
        public void Move()
        { Console.WriteLine("Wooden Box Shifted"); }
        public override string ToString()
        {
            return "Tom and Jerry";
            
        }


    }
    internal class BoxTester
        {
            public static void Testtwo()
            {
                Box box = new Box(100);
                box.Height = 10;
                box.Length = 20;
                box.Width = 5;
                box.Open();
                box.Close();
                box.ToString();
                String output = box.ToString();
                
            Console.WriteLine(output);
            }
        public static void TestThree()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.Length = 200;
            box.Width = 50;
            box.Open();
            box.Close();
            String outbox = box.ToString();
            box.Move();
            Console.WriteLine(outbox);





        }
        public static void TestFour()
        {
            Box box = new WoodenBox(); // 1st it will look for methods in  child class and then it goes to parent class
            box.Height = 110; // not in child class but in parent class
            box.Length = 150;
            box.Width = 150;
            box.Open();
            box.Close();
            String outbox = box.ToString(); // In child class
            // box.Move();
            Console.WriteLine(outbox);

        }
    }
    }

