using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBD
{
    public partial class WinDBForm2 : Form
    {
        public WinDBForm2()
        {
            InitializeComponent();
        }
        DataView ЗаказчикиDataView;
        private void button1_Click(object sender, EventArgs e)
        {
            // // Завантаження таблиці даними : 
            замовникиTableAdapter1.Fill(dbWinDBDataSet1.Замовники);
            // // Налаштування об'єкту DataView
            ЗаказчикиDataView = new DataView(dbWinDBDataSet1.Замовники);
            // // Налаштування dataGridView для відображення даних
            dataGridView1.DataSource = ЗаказчикиDataView;
            // // Привласнення початкового порядку сортування
            ЗаказчикиDataView.Sort = "Прізвище";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(dataSet11);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ЗаказчикиDataView.Sort = SortTextBox.Text;
            ЗаказчикиDataView.RowFilter = FilterTextBox.Text;
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}