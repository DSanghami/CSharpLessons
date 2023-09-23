using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Answer
{
    internal class Bank
    {
        public static void BankDetails()
        {
            string BankName = "HDFC";
            int BankId = 0;
            string Bankbranch = "Guindy";
        }
        
        
    }
    class CustomerDetails : Bank
    {
        public static void BankDetails()
        {
            string customerName;
            string CustomerId;
            DateTime dob; 
        }
        public void CustAccDetails()
        {
            int Accountno;
            int AccBalance;
            DateTime LastTransaction;
        }

    }
    class Account
    {
        public readonly long AccountNumber;
        public readonly int CustomerID;
        
        public const float MIN_Balance = 2000f;
        public const float Max_Balance = 1000f;
        
    }
}


// Account account =new AccountI(32453w4,4634);
// MessageController messageControlller = new MessageController();\

// accountcontroller.EmailSignal += messageController // += mrathod add and -= meathod sub