using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;



namespace MainMenu1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Lab1.exe"); //відкриває *.exe до завдання 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Process.Start("Ex2_1.exe"); //відкриває *.exe до завдання 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Ex2.exe"); //відкриває *.exe до завдання 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("Dop.exe"); //відкриває *.exe до додаткового завдання;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Author.exe"); //відкриває інформацію про атвора;
            linkLabel1.LinkVisited = true;
        }
    }
}
