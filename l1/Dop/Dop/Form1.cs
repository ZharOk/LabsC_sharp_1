using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //обробник подій при загрузці форми
        {
            this.WindowState = FormWindowState.Maximized; // відкрити на весь екран
        }

        private void button1_Click(object sender, EventArgs e) // обробник події клік
        {
            this.WindowState = FormWindowState.Normal; // вийти з повноекранного режиму
            this.Size = new Size(500, 300); // змынити розмыри форми.
        }

        private void button2_Click(object sender, EventArgs e)// обробник події клік
        {
            Hide(); // приховати
            MessageBox.Show("FIOT IS-41(02) Bevz D.O.", "About author", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // вивести текст
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // обробник подыъ закривання форми
        {
            MessageBox.Show("Bye", "My Application",
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk); // вивести текст
        }
        
    }
}
