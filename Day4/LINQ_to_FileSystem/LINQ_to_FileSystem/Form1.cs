using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_to_FileSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir= new DirectoryInfo(@"C:\");
            var folders = from f in dir.GetFiles()
                          
                          select f;

            dataGridView1.DataSource = folders.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var extension = "";

            if(comboBox1.SelectedItem.ToString() == "Word")
                extension = ".docx";
            else if (comboBox1.SelectedItem.ToString() == "Excel")
                extension = ".xlsx";
            else if (comboBox1.SelectedItem.ToString() == "PPT")
                extension = ".pptx";
            else if (comboBox1.SelectedItem.ToString() == "Zip")
                extension = ".zip";
            else
                extension = ".txt";

            var path = new DirectoryInfo(@"C:\Users\gajens2\Desktop\Folder");

            var files = from a in path.GetFiles()
                        where a.Extension == extension
                        select a;

            dataGridView1.DataSource = files.ToList();
        }
    }
}
