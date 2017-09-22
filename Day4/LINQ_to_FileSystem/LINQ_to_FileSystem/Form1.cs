using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LINQ_to_FileSystem
{
    public partial class Form1 : Form
    {
        DirectoryInfo path = new DirectoryInfo(@"C:\Users\gajens2\Desktop\Folder");
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
            //showing selected extensions files
            var files = from a in path.GetFiles()
                        where a.Extension == comboBox1.SelectedItem.ToString() 
                        select a;

            dataGridView1.DataSource = files.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adding all extensions in comboBox1
            var files = from f in path.GetFiles()
                        select f;
            var ext = (from f in files
                       select f.Extension).Distinct();

            foreach (string item in ext)
                comboBox1.Items.Add(item);
            
        }
    }
}
