using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitDemo
{
    public partial class AsyncAwaitDemo2 : Form
    {
        public AsyncAwaitDemo2()
        {
            InitializeComponent();
        }

        private void AsyncAwaitDemo2_Load(object sender, EventArgs e)
        {

        }

        private string BookFlight()
        {
            Thread.Sleep(30000);
            return "Flight Booked, Booking Id 101";
        }

        private string BookHotel()
        {
            Thread.Sleep(40000);
            return "Hotel Booked, Booking Id 102";
        }

        private string BookGuide()
        {
            Thread.Sleep(20000);
            return "Guide Booked, Booking Id 103";
        }

        private string EmailConfirmation()
        {
            Thread.Sleep(60000);
            return "Email Sent";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            #region serial
            //label1.Text = BookFlight();
            //label2.Text = BookHotel();
            //label3.Text = BookGuide();
            //label4.Text = EmailConfirmation();
            #endregion

            #region only parallelism, not async-await, form hangs
            //Task<string> taskBookHotel = new Task<string>(BookHotel);
            //Task<string> taskBookFlight = new Task<string>(BookFlight);
            //Task<string> taskBookGuide = new Task<string>(BookGuide);
            //Task<string> taskEmailConfirmation = new Task<string>(EmailConfirmation);

            //taskBookHotel.Start();
            //taskBookFlight.Start();
            //taskBookGuide.Start();
            //taskEmailConfirmation.Start();

            //label1.Text = taskBookFlight.Result;
            //label2.Text = taskBookHotel.Result;
            //label3.Text = taskBookGuide.Result;
            //label4.Text = taskEmailConfirmation.Result;
            #endregion

            label1.Text = await Task<string>.Run(() => BookFlight());
            label2.Text = await Task<string>.Run(() => BookHotel());
            label3.Text = await Task<string>.Run(() => BookGuide());
            label4.Text = await Task<string>.Run(() => EmailConfirmation());

            //label1.Text = await (new Thread(new ThreadStart(BookFlight)))

        }
    }
}
