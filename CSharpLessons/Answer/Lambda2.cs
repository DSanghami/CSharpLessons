using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    
        class ServiceA
        {
        int x = 0; // Global variable is shared between both files . When two or more threads access. With global 
            public void DoTaskA()
            {
            Monitor.Enter(this);
            Thread t1 = Thread.CurrentThread; // Os created this thread
                int id = t1.ManagedThreadId; // OS give ID
                Console.Write("Inside DoTaskA");
                Console.WriteLine("\t Thread ID: " + id);
            // int x = 0;
            /**/
            try
            {
                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("\tID=" + id + ":X=" + x + "icount=" + icount);
                    Thread.Sleep(1000);//lopp will stop for 1000 millisec
                }
            }
            finally
            {
                Monitor.Exit(this);
            }


            }
        }
    }

