using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            string docPath =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] data = { "Student Number: " + textBox1.Text, "Full Name: " + textBox2, " " + textBox3, "" + textBox4, 
            "Program: " + comboBox1, "Gender: " + comboBox2, "Age: " + textBox5, "Birthday: " + dateTimePicker1.Value.ToString("yyyy-mm-dd")
            , "Contact No: " + textBox6.Text};
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,Form2.FileName)))
            {
                foreach (string infos in data)
                {
                    outputFile.WriteLine(infos);
                }
            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Hide();
        }
    }
}
