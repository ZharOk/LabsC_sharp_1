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

namespace WinBD
{
    public partial class WinDBForm1 : Form
    {
        public WinDBForm1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WinDBForm2 Exercise2 = new WinDBForm2();
            Exercise2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbDataReader myReader; string CustomerString; oleDbConnection1.Open();
            myReader = oleDbCommand1.ExecuteReader();
            while (myReader.Read())
            {
                // // Витягнути список імен і прізвищ з таблиці 
                // // Замовники і виконати їх контактенацию.
                CustomerString = myReader[1].ToString() + " " + myReader[2].ToString();
                // // Додати результат в список ListBox
                listBox1.Items.Add(CustomerString);
            }
            myReader.Close(); oleDbConnection1.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Author.exe"); //відкриває інформацію про атвора;і
        }

        private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }
    }
}
