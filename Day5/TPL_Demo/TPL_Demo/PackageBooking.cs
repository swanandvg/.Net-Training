using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_Demo
{
    class PackageBooking
    {
        public System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        public string BookFlight()
        {
            Console.WriteLine("Book Flight Started");
            Thread.Sleep(10000);
            Console.WriteLine("Book Flight Successful");
            return "ZKP10234";
        }

        public int BookHotel()
        {
            Console.WriteLine("Book Hotel Started");
            Thread.Sleep(30000);
            Console.WriteLine("Book Hotel Successful");
            return 123;
        }

        public bool BookGuide()
        {
            Console.WriteLine("Book Guide Started");
            Thread.Sleep(20000);
            Console.WriteLine("Book Guide Successful");
            return true;
        }

        public int ProcessPayment()
        {
            Console.WriteLine("Process Payment Started");
            Thread.Sleep(20000);
            Console.WriteLine("Process Payment Successful");
            return 4000;
        }

        public void SpecialRequest()
        {
            Console.WriteLine("Special Request Started");
            Thread.Sleep(40000);
            Console.WriteLine("Special Request Successful");
        }

        public void SendEmailSMS()
        {
            Console.WriteLine("Send Email/SMS Started");
            Thread.Sleep(15000);
            Console.WriteLine("Send Email/SMS Successful");
        }
    }

}
