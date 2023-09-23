using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectK.Day3
{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void RecieveMessage();
        void DeleteMessage();
    }

    public interface IPayments
    {
        void MakePayment();
    }
    internal class WhatsApp : IMessageService, IPayments
    {
        public void DeleteMessage()
        {
            Console.WriteLine("Method Not Implemented");

        }
        public void RecieveMessage()
        {
            Console.WriteLine("Method Not Implemented");

        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");

        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");

        }

        /*public void Makepayment()
        {
            // Console.WriteLine("Hi");
        } */

        // public abstract void SendVideoMessage(String message);
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");

        }
    }
    public class MessageTester
    {
        public static void TestiOne()
        {
            IMessageService messageService = new WhatsApp();
            messageService.SendMessage("hello");
            messageService.RecieveMessage();
        }

    }
}
