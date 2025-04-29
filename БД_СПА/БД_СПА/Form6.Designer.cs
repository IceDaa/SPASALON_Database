namespace БД_СПА
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label мастерLabel;
            System.Windows.Forms.Label процедураLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.сПА_САЛОН_БДDataSet1 = new БД_СПА.СПА_САЛОН_БДDataSet1();
            this.заказы_на_МартBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказы_на_МартTableAdapter = new БД_СПА.СПА_САЛОН_БДDataSet1TableAdapters.Заказы_на_МартTableAdapter();
            this.tableAdapterManager = new БД_СПА.СПА_САЛОН_БДDataSet1TableAdapters.TableAdapterManager();
            this.заказы_на_МартBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заказы_на_МартBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            фИОLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            мастерLabel = new System.Windows.Forms.Label();
            процедураLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сПА_САЛОН_БДDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказы_на_МартBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказы_на_МартBindingNavigator)).BeginInit();
            this.заказы_на_МартBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            фИОLabel.Location = new System.Drawing.Point(121, 80);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(46, 17);
            фИОLabel.TabIndex = 2;
            фИОLabel.Text = "ФИО:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            датаLabel.Location = new System.Drawing.Point(121, 116);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(46, 17);
            датаLabel.TabIndex = 4;
            датаLabel.Text = "Дата:";
            // 
            // мастерLabel
            // 
            мастерLabel.AutoSize = true;
            мастерLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            мастерLabel.Location = new System.Drawing.Point(121, 150);
            мастерLabel.Name = "мастерLabel";
            мастерLabel.Size = new System.Drawing.Size(61, 17);
            мастерLabel.TabIndex = 6;
            мастерLabel.Text = "Мастер:";
            // 
            // процедураLabel
            // 
            процедураLabel.AutoSize = true;
            процедураLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            процедураLabel.Location = new System.Drawing.Point(121, 183);
            процедураLabel.Name = "процедураLabel";
            процедураLabel.Size = new System.Drawing.Size(85, 17);
            процедураLabel.TabIndex = 8;
            процедураLabel.Text = "Процедура:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Заказы на март\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // сПА_САЛОН_БДDataSet1
            // 
            this.сПА_САЛОН_БДDataSet1.DataSetName = "СПА_САЛОН_БДDataSet1";
            this.сПА_САЛОН_БДDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказы_на_МартBindingSource
            // 
            this.заказы_на_МартBindingSource.DataMember = "Заказы_на_Март";
            this.заказы_на_МартBindingSource.DataSource = this.сПА_САЛОН_БДDataSet1;
            // 
            // заказы_на_МартTableAdapter
            // 
            this.заказы_на_МартTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = БД_СПА.СПА_САЛОН_БДDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Данные_о_клиентахTableAdapter = null;
            this.tableAdapterManager.Заказы_на_МартTableAdapter = this.заказы_на_МартTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Таблица1TableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // заказы_на_МартBindingNavigator
            // 
            this.заказы_на_МартBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказы_на_МартBindingNavigator.BindingSource = this.заказы_на_МартBindingSource;
            this.заказы_на_МартBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказы_на_МартBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказы_на_МартBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.заказы_на_МартBindingNavigatorSaveItem});
            this.заказы_на_МартBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказы_на_МартBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказы_на_МартBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказы_на_МартBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказы_на_МартBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказы_на_МартBindingNavigator.Name = "заказы_на_МартBindingNavigator";
            this.заказы_на_МартBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказы_на_МартBindingNavigator.Size = new System.Drawing.Size(484, 25);
            this.заказы_на_МартBindingNavigator.TabIndex = 1;
            this.заказы_на_МартBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // заказы_на_МартBindingNavigatorSaveItem
            // 
            this.заказы_на_МартBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказы_на_МартBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказы_на_МартBindingNavigatorSaveItem.Image")));
            this.заказы_на_МартBindingNavigatorSaveItem.Name = "заказы_на_МартBindingNavigatorSaveItem";
            this.заказы_на_МартBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказы_на_МартBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказы_на_МартBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказы_на_МартBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(124, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(343, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Вперед";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(124, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Начало";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(343, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Конец";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button7.Location = new System.Drawing.Point(12, 159);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 64);
            this.button7.TabIndex = 24;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Location = new System.Drawing.Point(4, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 64);
            this.button6.TabIndex = 25;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(386, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказы_на_МартBindingSource, "ФИО", true));
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBox1.Location = new System.Drawing.Point(173, 77);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(299, 23);
            this.maskedTextBox1.TabIndex = 27;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказы_на_МартBindingSource, "Дата", true));
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBox2.Location = new System.Drawing.Point(173, 110);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(299, 23);
            this.maskedTextBox2.TabIndex = 28;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказы_на_МартBindingSource, "Мастер", true));
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBox3.Location = new System.Drawing.Point(188, 147);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(284, 23);
            this.maskedTextBox3.TabIndex = 29;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказы_на_МартBindingSource, "Процедура", true));
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBox4.Location = new System.Drawing.Point(212, 180);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(260, 23);
            this.maskedTextBox4.TabIndex = 30;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(процедураLabel);
            this.Controls.Add(мастерLabel);
            this.Controls.Add(датаLabel);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.заказы_на_МартBindingNavigator);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.Text = "Таблица \"Заказы на март\"";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сПА_САЛОН_БДDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказы_на_МартBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказы_на_МартBindingNavigator)).EndInit();
            this.заказы_на_МартBindingNavigator.ResumeLayout(false);
            this.заказы_на_МартBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private СПА_САЛОН_БДDataSet1 сПА_САЛОН_БДDataSet1;
        private System.Windows.Forms.BindingSource заказы_на_МартBindingSource;
        private СПА_САЛОН_БДDataSet1TableAdapters.Заказы_на_МартTableAdapter заказы_на_МартTableAdapter;
        private СПА_САЛОН_БДDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказы_на_МартBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton заказы_на_МартBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
    }
}