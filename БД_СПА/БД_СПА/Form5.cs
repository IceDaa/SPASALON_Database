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
    public partial class Form5: Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сПА_САЛОН_БДDataSet1.Данные_о_клиентах". При необходимости она может быть перемещена или удалена.
            this.данные_о_клиентахTableAdapter1.Fill(this.сПА_САЛОН_БДDataSet1.Данные_о_клиентах);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сПА_САЛОН_БДDataSet.Данные_о_клиентах". При необходимости она может быть перемещена или удалена.
            this.данные_о_клиентахTableAdapter.Fill(this.сПА_САЛОН_БДDataSet.Данные_о_клиентах);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void данные_о_клиентахBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.данные_о_клиентахBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сПА_САЛОН_БДDataSet);

        }

        private void телефонTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.данные_о_клиентахBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.данные_о_клиентахBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.данные_о_клиентахBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.данные_о_клиентахBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.данные_о_клиентахBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.данные_о_клиентахBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.данные_о_клиентахBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сПА_САЛОН_БДDataSet);
        }
    }
}
