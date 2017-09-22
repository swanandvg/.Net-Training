using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Thread Programming Demo 1
namespace TPL_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            PackageBooking pkjObj = new PackageBooking();

            Task<string> taskBookFlight = new Task<string>(pkjObj.BookFlight);
            Task<int> taskBookHotel = new Task<int>(pkjObj.BookHotel);
            Task<bool> taskBookGuide = new Task<bool>(pkjObj.BookGuide);
            
            Task<int> taskProcessPayment = null;
            Task taskSpecialRequest = null;
            Task taskSendEmailSMS = null;

            Console.WriteLine("You want special request : (y/n) :");
            char ch = (char)Console.Read();
            ch = Char.ToLower(ch);

            switch (ch)
            {
                case 'y':
                    taskSpecialRequest = taskBookHotel.ContinueWith(t => pkjObj.SpecialRequest());
                    taskProcessPayment = taskSpecialRequest.ContinueWith(t => pkjObj.ProcessPayment());
                    taskSendEmailSMS = taskProcessPayment.ContinueWith(t => pkjObj.SendEmailSMS());
                    //taskSpecialRequest = taskBookHotel.ContinueWith(t => pkjObj.SpecialRequest());
                    //taskProcessPayment = new Task<int>(pkjObj.ProcessPayment);
                    //taskSendEmailSMS = new Task(pkjObj.SendEmailSMS);

                    pkjObj.watch.Start();

                    taskBookHotel.Start();
                    taskBookGuide.Start();
                    taskBookFlight.Start();

                    //taskProcessPayment.Start();
                    //taskSendEmailSMS.Start();

                    taskBookFlight.Wait();
                    taskBookGuide.Wait();
                    taskBookHotel.Wait();
                    taskSpecialRequest.Wait();
                    taskProcessPayment.Wait();
                    taskSendEmailSMS.Wait();

                    pkjObj.watch.Stop();
                    Console.WriteLine("Total time taken " + pkjObj.watch.ElapsedMilliseconds);
                    Console.WriteLine("Output task Book Hotel : " + taskBookHotel.Result);
                    Console.WriteLine("Output task Book Flight : " + taskBookFlight.Result);
                    Console.WriteLine("Output task Book Guide : " + taskBookGuide.Result);
                    //(taskSpecialRequest!=null)?Console.WriteLine("Output task Special Request : " + taskSpecialRequest.Result):;
                    Console.WriteLine("Output task Process Payment : " + taskProcessPayment.Result);
                    break;
                case 'n':
                    taskProcessPayment = taskBookHotel.ContinueWith(t => pkjObj.ProcessPayment());
                    taskSendEmailSMS = taskProcessPayment.ContinueWith(t => pkjObj.SendEmailSMS());
                    //taskProcessPayment = new Task<int>(pkjObj.ProcessPayment);
                    //taskSendEmailSMS = new Task(pkjObj.SendEmailSMS);
                    pkjObj.watch.Start();

                    taskBookHotel.Start();
                    taskBookGuide.Start();
                    taskBookFlight.Start();

                    taskProcessPayment.Start();
                    taskSendEmailSMS.Start();

                    taskBookFlight.Wait();
                    taskBookGuide.Wait();
                    taskBookHotel.Wait();
                    //taskProcessPayment.Wait();
                    //taskSendEmailSMS.Wait();

                    pkjObj.watch.Stop();
                    Console.WriteLine("Total time taken " + pkjObj.watch.ElapsedMilliseconds);
                    Console.WriteLine("Output task Book Hotel : " + taskBookHotel.Result);
                    Console.WriteLine("Output task Book Flight : " + taskBookFlight.Result);
                    Console.WriteLine("Output task Book Guide : " + taskBookGuide.Result);
                    //(taskSpecialRequest!=null)?Console.WriteLine("Output task Special Request : " + taskSpecialRequest.Result):;
                    Console.WriteLine("Output task Process Payment : " + taskProcessPayment.Result);
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    //Environment.Exit(0);
                    break;
            }

            

            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            ////Method1();
            ////Method2();
            ////Method3();

            ////NOT MSDN WAY
            ////Thread t1 = new Thread(new ThreadStart(Method1));
            ////Thread t2 = new Thread(new ThreadStart(Method2));
            ////Thread t3 = new Thread(new ThreadStart(Method3));
            ////t1.Start();
            ////t2.Start();
            ////t3.Start();



            ////MSDN Way
            ////If return type is void
            ////Task m1 = new Task(Method1);
            ////Task m2 = new Task(Method2);
            ////Task m3 = new Task(Method3);

            ////If return type != void
            //Task<int> m1 = new Task<int>(Method1);
            //Task<int> m2 = new Task<int>(Method2);
            //Task<int> m3 = new Task<int>(Method3);
            //Task<int> m4 = new Task<int>(Method4);

            //m1.Start();
            //m2.Start();
            //m3.Start();

            //m4 = m2.ContinueWith(t => Method4());

            //m1.Wait();
            //m2.Wait();
            //m3.Wait();

            //Console.WriteLine("Method 1 returned " + m1.Result);
            //Console.WriteLine("Method 2 returned " + m2.Result);
            //Console.WriteLine("Method 3 returned " + m3.Result);
            //Console.WriteLine("Method 4 returned " + m4.Result);

            //watch.Stop();
            //Console.WriteLine("Time Taken "+watch.ElapsedMilliseconds);
        }
        public static int Method1()
        {
            Console.WriteLine("Method 1 Started");
            Thread.Sleep(18000);
            Console.WriteLine("Method 1 Ended");
            return 1;

        }
        public static int Method2()
        {
            Console.WriteLine("Method 2 Started");
            Thread.Sleep(8000);
            Console.WriteLine("Method 2 Ended");
            return 2;
        }
        public static int Method3()
        {
            Console.WriteLine("Method 3 Started");
            Thread.Sleep(14000);
            Console.WriteLine("Method 3 Ended");
            return 3;
        }
        public static int Method4()
        {
            Console.WriteLine("Method 4 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Method 4 Ended");
            return 4;
        }
    }
}
