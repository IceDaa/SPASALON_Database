﻿using System;
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
    public partial class Form6: Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сПА_САЛОН_БДDataSet1.Заказы_на_Март". При необходимости она может быть перемещена или удалена.
            this.заказы_на_МартTableAdapter.Fill(this.сПА_САЛОН_БДDataSet1.Заказы_на_Март);

        }

        private void заказы_на_МартBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказы_на_МартBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сПА_САЛОН_БДDataSet1);

        }

     

        private void фИОTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.заказы_на_МартBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.заказы_на_МартBindingSource.MoveNext();
        }
    }
}
