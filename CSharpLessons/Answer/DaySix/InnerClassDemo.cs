using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
 

namespace Answer.DaySix
{
    internal class InnerClassDemo
    {
        class Emp
        {
            public int Eno = 0;
            private readonly Address address;
            public Emp()
            {
                address = new Address(this);
            }
            public Address GetAddress()
            {
                return address;
            }
            public class Address
            {
                public string Address1;
                public string Address2;
                private readonly Emp el; // outer object should be exist so that we can access the inner class

                internal Address(Emp outerEmp)
                {
                    if (outerEmp == null)
                        throw new NullReferenceException("Outer emp is null");
                    el = outerEmp;
                }
                public override string ToString()
                {
                    return Address1 + "," + Address2 + "of" + el.Eno;
                }

            }

        }
    }
}
