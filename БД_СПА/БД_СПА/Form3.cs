using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БД_СПА
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сПА_САЛОН_БДDataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.сПА_САЛОН_БДDataSet.Таблица1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сПА_САЛОН_БДDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            сотрудникиTableAdapter.Fill(this.сПА_САЛОН_БДDataSet.Сотрудники);
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сПА_САЛОН_БДDataSet);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сПА_САЛОН_БДDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.RemoveCurrent();
        }

        private void maskedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedtextbox2DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

     
       

        private void должностьTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
