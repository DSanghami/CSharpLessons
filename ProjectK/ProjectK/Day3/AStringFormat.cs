using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectK.Day3
{
    internal class AStringFormat
    {
        public static void LeaveLetterTemplate()
        {
            String letter = "Sir,\n As I am suffering from {4} , I want leave for {3} days,\n from {1} to {2}.\n\n Thank You \n {0}";

            String reason = "fever";
            String myName = "Venkat";
            String no_of_Days = "4";
            String fromdate = "6-Aug-2018";
            String todate = "9-Aug-2018";

            String s1 = String.Format(letter, myName, fromdate, todate, no_of_Days, reason);

            Console.WriteLine(s1);
        }
    }

}

