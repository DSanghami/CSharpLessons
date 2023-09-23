using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayThree
{
    internal class Inheritance
    {
        public int Height;
        public int Length;
        public int Width;

        public Inheritance(int x)
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
        public override string ToString()
        {
            return $"Height: {Height}, Length: {Length}, Width: {Width}";
        }
    }
    internal class WoodenBox : Inheritance
    {
        public int Area;
        public WoodenBox() : base(1000) // child class
        {
            Console.WriteLine("Woodenbox Constructor");
        }
        public WoodenBox(int y) : base(y) // child class
        {
            Console.WriteLine("Woodenbox Constructor");
        }
        public WoodenBox(int x, int y) : base(y) // child class - here, woodenbox has 2 parameters but 
        {
            Console.WriteLine("Woodenbox Constructor");

        }
        public void Move()
        {
            Console.WriteLine("Wooden box shifted");
        }

        public override string ToString()
        {
            return $"Dora and Bhuji";
        }

    }
    internal class BoxTester
    {
        public static void TestOne()
        {
            Inheritance box = new Inheritance(100);
            box.Height = 10;
            box.Length = 20;
            box.Width = 5;
            box.Open();
            box.Close();
            String outbox = box.ToString();
            Console.WriteLine(outbox);
            // box.Area = 300; - child properties wont accept by the parent class
            // box.Move();

        }

        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();
            box.Height = 100;
            box.Length = 200;
            box.Width = 50;
            box.Open();
            box.Close();
            String outbox = box.ToString();
            Console.WriteLine(outbox);
            box.Area = 100;
            box.Move();

        }

        public static void TestThree()
        {
            Inheritance box = new WoodenBox();
            box.Height = 1000;
            box.Length = 2000;
            box.Width = 500;
            box.Open();
            box.Close();
            String outbox = box.ToString();
            Console.WriteLine(outbox);
            String output = box.ToString();
            Console.WriteLine(output);
            //box.Area = 100; - wont work 
            //box.Move();

        }
    }
}
