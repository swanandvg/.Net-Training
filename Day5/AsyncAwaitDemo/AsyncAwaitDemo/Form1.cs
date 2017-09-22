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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Method1()
        {
            Thread.Sleep(40000);   
        }
        private void Method2()
        {
            Thread.Sleep(40000);
        }
        private int Counter(ref Label l)
        {
            int num = 0;
            for (; num < 500000; ++num)
                l.Text = num.ToString();
            return num;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Processing...";
            //Method1();
            //label3.Text = "Done";
            label1.Text = await Task.Run(() => Counter(ref label3).ToString());
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Processing...";
            //Method2();
            //label4.Text = "Done";
            label2.Text = await Task.Run(() => Counter(ref label4).ToString());
        }
    }
}
