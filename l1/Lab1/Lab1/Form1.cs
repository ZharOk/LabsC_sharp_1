using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// обробник події клік.
        {
            this.FormBorderStyle = FormBorderStyle.Sizable; // змінити тип границі форми.
        }

        private void button2_Click(object sender, EventArgs e)// обробник події клік.
        {
            this.Size = new Size(300, 500); //нвий розмір вікна
        }

        private void button3_Click(object sender, EventArgs e) // обробник події клік.
        {
            this.Opacity = 1; // зробити форму непрозорою
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
