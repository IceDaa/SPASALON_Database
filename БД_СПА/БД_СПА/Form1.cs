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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void заказы_на_МартBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказы_на_МартBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сПА_САЛОН_БДDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сПА_САЛОН_БДDataSet.Данные_о_клиентах". При необходимости она может быть перемещена или удалена.
            this.данные_о_клиентахTableAdapter.Fill(this.сПА_САЛОН_БДDataSet.Данные_о_клиентах);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сПА_САЛОН_БДDataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.сПА_САЛОН_БДDataSet.Таблица1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сПА_САЛОН_БДDataSet.Заказы_на_Март". При необходимости она может быть перемещена или удалена.
            this.заказы_на_МартTableAdapter.Fill(this.сПА_САЛОН_БДDataSet.Заказы_на_Март);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {

                case 0:
                    Col = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn5;
                    break;
            }
            if (Col != null)
            {
                if (radioButton1.Checked)
                {
                    заказы_на_МартDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
                }
                else if (radioButton2.Checked)
                {
                    заказы_на_МартDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
                }
                else
                {
                    MessageBox.Show("Выберите направление сортировки.");
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            заказы_на_МартBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            заказы_на_МартBindingSource.Filter = "Дата='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            int j = 0;

            for (i = 0; i < заказы_на_МартDataGridView.ColumnCount - 1; i++)
            {
                for (j = 0; j < заказы_на_МартDataGridView.RowCount - 1; j++)
                {
                    заказы_на_МартDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    заказы_на_МартDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < заказы_на_МартDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < заказы_на_МартDataGridView.RowCount; j++)
                {
                    var value = заказы_на_МартDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();

                        if (baseStr.IndexOf(textBox1.Text) > -1)
                        {
                            заказы_на_МартDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            заказы_на_МартDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }
    }
}
    

      