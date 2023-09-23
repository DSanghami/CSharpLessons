/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Answer.DaySix
{
    public enum fuelType
    {
        Petrol,Diesel,gas
    }
    internal class CarInnerClass
    {
        public int RegNo;
        public string Model;
        public CarInnerClass()
        {
            caraddress = new CarAddress(this);
        }
        public CarAddress GetAddress()
        {
            return caraddress;
        }
        public class CarAddress
        {
            public string CarAddress1;
            public string CarAddress2;
            private readonly  el; // outer object should be exist so that we can access the inner class

            internal CarAddress(CarInnerClass outerEmp)
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
*/