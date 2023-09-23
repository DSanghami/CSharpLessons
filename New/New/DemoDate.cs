using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace New
{
    internal class DemoDate
    {
        public static void FirstMethod()
        {
            DateTime d1 = new DateTime(2018, 04, 18);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());
        }
        public static void SecondMethod()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            int year = d1.Year;
            Console.WriteLine("Year OF Dob " + year);
            int month = d1.Month;
            Console.WriteLine("Month OF Dob " + month);
            int day = d1.Day;
            Console.WriteLine("Day OF Dob " + day);
            DateTime d2 = d1.AddMonths(10);
            Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
            DateTime d3 = d1.AddDays(5);
            Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
            DateTime d4 = d1.AddYears(58);
            Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
            DateTime d5 = d1.AddYears(-5);
            Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        }
        public static void ThirdMethod()
        {
            Console.WriteLine("You DOB");
            String dob = String.Empty;
            try
            {
                dob = Console.ReadLine();
                DateTime dob1 = DateTime.Parse(dob);
                DateTime now = DateTime.Now;
                TimeSpan ts = now.Subtract(dob1);
                DateTime age = new DateTime(ts.Ticks);
                Console.WriteLine(age.ToShortDateString());
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            
            /* int NYear = now.Year;
             int NMonth = now.Month;
             int NDay = now.Day;
             int YearAge = NYear - year;
             Console.WriteLine("Year" + YearAge);
             if (month < NMonth)
             {
                 int MonthAge = NMonth - month;
             }
             else*/
           

        }
        public static void FourthMethod() {
            Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
            string dobString = String.Empty;
            try
            {
                dobString = Console.ReadLine();
                if (dobString == null)
                {
                    Console.WriteLine("Date Of Birth is NULL!!!");
                    return;
                }
                // Parse the date of birth
                DateTime dob = DateTime.Parse(dobString);

                // Calculate the age
                DateTime now = DateTime.Now;
                int ageYears = now.Year - dob.Year;
                if (now < dob.AddYears(ageYears))
                {
                    ageYears--;
                }
                int ageMonths = now.Month - dob.Month;
                if (now < dob.AddMonths(ageMonths).AddDays(now.Day - dob.Day))
                {
                    ageMonths--;
                }
                int ageDays = now.Day - dob.Day;
                if (now.Day < dob.Day)
                {
                    ageDays += DateTime.DaysInMonth(now.Year, now.Month);
                }
                // Print the age
                Console.WriteLine(
                    $"You are {ageYears} years, {ageMonths} months, and {ageDays} days old."
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void FifthMethos()
        {
            Console.WriteLine("DOB: ");
            string dobString = String.Empty;
            try
            {
                dobString = Console.ReadLine();
                if (dobString == null)
                {
                    Console.WriteLine("Date Of Birth is NULL!!!");
                    return;
                }
                DateTime dob = DateTime.Parse(dobString);
                DateTime nextMonthFirstDay = new DateTime(dob.Year + 60, dob.Month + 1, 1);
                DateTime retirementdate = nextMonthFirstDay.AddDays(-1);
                Console.WriteLine("Your Retirement Date is" + retirementdate.ToShortDateString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public enum City { Chennai, Bangalore, Hyderabad, Pune};
        public enum Destination { Manager, Admid, Developer};
        internal class Employee
        {
            public readonly int Id;
            public string Ename;
            public City Ecity ;
            public Destination JobTitle;
            public Employee(int v1)
            {
                Id = v1;
            }
            public override String ToString()
            {
                String output = String.Empty;
                output = $"Details of a employee are: ID = {Id} Name={Ename} {Ecity} {JobTitle}";
                return output;
            }
        }
        class TestEmployee
        {
            public static void TestOne()
            {
                Employee e1 = new Employee(348);
                e1.Ename = "John";
                e1.Ecity = City.Bangalore;
                e1.JobTitle = Destination.Developer;
                String output = e1.ToString();
                Console.WriteLine(output);
            }
        }


    }
}
