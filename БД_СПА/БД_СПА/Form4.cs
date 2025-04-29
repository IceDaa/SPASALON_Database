using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace БД_СПА
{
    public partial class Form4: Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сПА_САЛОН_БДDataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.сПА_САЛОН_БДDataSet.Таблица1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сПА_САЛОН_БДDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.сПА_САЛОН_БДDataSet.Товары);

        }

        private void товарыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сПА_САЛОН_БДDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.товарыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.товарыBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.товарыBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.товарыBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.товарыBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.товарыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сПА_САЛОН_БДDataSet);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.товарыBindingSource.RemoveCurrent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double ant, bnt;

            // Получаем текст из поля и конвертируем
            if (double.TryParse(maskedTextBox3.Text, out ant))
            {
                bnt = (118 * ant) / 100;
                comboBox1.Text = bnt.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректное число в maskedTextBox3.");
            }
        }
        private void maskedTextBox3_MaskInputRejected(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
