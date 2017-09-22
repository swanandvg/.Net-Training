using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_Demo
{
    //Program done by other guy in training
    //Main is commented as two Main Functions are in same namespace
    //to run this, comment another Main() and uncomment this 
    class Program1
    {
        //static void Main(string[] args)
        //{
        //    Stopwatch watch = new Stopwatch();
        //    Console.WriteLine("Do you have any speacial request?");
        //    var choice = Console.ReadLine();
        //    watch.Start();
        //    Task<string> bookFlight = new Task<string>(BoookFlight);
        //    Task<int> bookHotel = new Task<int>(BookHotel);
        //    Task<bool> bookGuide = new Task<bool>(BookGuide);
        //    Task<int> processPayment = new Task<int>(ProcessPayment);
        //    Task specialRequest = new Task(SpecialRequest);
        //    Task sendEmail = new Task(SendEmail);

        //    bookFlight.Start();
        //    bookHotel.Start();
        //    bookGuide.Start();
        //    sendEmail.Start();
        //    processPayment.Start();

        //    if (choice == "yes")
        //    {
        //        Task.WaitAll(bookFlight, bookHotel, bookGuide);
        //        specialRequest.Start();
        //        specialRequest.Wait();
        //    }

        //    bookFlight.Wait();
        //    bookHotel.Wait();
        //    bookGuide.Wait();
        //    processPayment.Wait();
        //    sendEmail.Wait();


        //    watch.Stop();
        //    Console.WriteLine("Time taken: " + watch.ElapsedMilliseconds / 1000);
        //}

        public static int ProcessPayment()
        {
            Console.WriteLine("ProcessPayment started");
            Thread.Sleep(20000);
            Console.WriteLine("ProcessPayment ends");
            return 1;
        }
        public static bool BookGuide()
        {
            Console.WriteLine("BookGuide started");
            Thread.Sleep(20000);
            Console.WriteLine("BookGuide ends");
            return true;
        }
        public static int BookHotel()
        {
            Console.WriteLine("BookHotel started");
            Thread.Sleep(30000);
            Console.WriteLine("BookHotel ends");
            return 4;
        }

        public static string BoookFlight()
        {
            Console.WriteLine("BoookFlight started");
            Thread.Sleep(10000);
            Console.WriteLine("BoookFlight ends");
            return "pnr : ssa121sasad";
        }
        public static void SpecialRequest()
        {
            Console.WriteLine("SpecialRequest started");
            Thread.Sleep(40000);
            Console.WriteLine("SpecialRequest ends");

        }

        public static void SendEmail()
        {
            Console.WriteLine("SendEmail started");
            Thread.Sleep(15000);
            Console.WriteLine("SendEmail ends");

        }

    }
}