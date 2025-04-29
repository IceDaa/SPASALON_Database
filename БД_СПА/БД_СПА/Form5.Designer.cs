namespace БД_СПА
{
    partial class Form5
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
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label дата_РегистрацииLabel;
            System.Windows.Forms.Label коментарийLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.сПА_САЛОН_БДDataSet = new БД_СПА.СПА_САЛОН_БДDataSet();
            this.данные_о_клиентахBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.данные_о_клиентахTableAdapter = new БД_СПА.СПА_САЛОН_БДDataSetTableAdapters.Данные_о_клиентахTableAdapter();
            this.tableAdapterManager = new БД_СПА.СПА_САЛОН_БДDataSetTableAdapters.TableAdapterManager();
            this.данные_о_клиентахBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.данные_о_клиентахBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.сПА_САЛОН_БДDataSet1 = new БД_СПА.СПА_САЛОН_БДDataSet1();
            this.данные_о_клиентахBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.данные_о_клиентахTableAdapter1 = new БД_СПА.СПА_САЛОН_БДDataSet1TableAdapters.Данные_о_клиентахTableAdapter();
            this.tableAdapterManager1 = new БД_СПА.СПА_САЛОН_БДDataSet1TableAdapters.TableAdapterManager();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            фИОLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            дата_РегистрацииLabel = new System.Windows.Forms.Label();
            коментарийLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сПА_САЛОН_БДDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_клиентахBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_клиентахBindingNavigator)).BeginInit();
            this.данные_о_клиентахBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сПА_САЛОН_БДDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_клиентахBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            фИОLabel.Location = new System.Drawing.Point(104, 75);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(46, 17);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            телефонLabel.Location = new System.Drawing.Point(105, 108);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(72, 17);
            телефонLabel.TabIndex = 5;
            телефонLabel.Text = "Телефон:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            emailLabel.Location = new System.Drawing.Point(105, 138);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            адресLabel.Location = new System.Drawing.Point(105, 174);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(52, 17);
            адресLabel.TabIndex = 9;
            адресLabel.Text = "Адрес:";
            // 
            // дата_РегистрацииLabel
            // 
            дата_РегистрацииLabel.AutoSize = true;
            дата_РегистрацииLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            дата_РегистрацииLabel.Location = new System.Drawing.Point(104, 210);
            дата_РегистрацииLabel.Name = "дата_РегистрацииLabel";
            дата_РегистрацииLabel.Size = new System.Drawing.Size(134, 17);
            дата_РегистрацииLabel.TabIndex = 11;
            дата_РегистрацииLabel.Text = "Дата Регистрации:";
            // 
            // коментарийLabel
            // 
            коментарийLabel.AutoSize = true;
            коментарийLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            коментарийLabel.Location = new System.Drawing.Point(105, 243);
            коментарийLabel.Name = "коментарийLabel";
            коментарийLabel.Size = new System.Drawing.Size(93, 17);
            коментарийLabel.TabIndex = 13;
            коментарийLabel.Text = "Коментарий:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(171, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 0);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица \"Сотрудники\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(104, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Таблица \"Данные о клиентах\"";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // сПА_САЛОН_БДDataSet
            // 
            this.сПА_САЛОН_БДDataSet.DataSetName = "СПА_САЛОН_БДDataSet";
            this.сПА_САЛОН_БДDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // данные_о_клиентахBindingSource
            // 
            this.данные_о_клиентахBindingSource.DataMember = "Данные_о_клиентах";
            this.данные_о_клиентахBindingSource.DataSource = this.сПА_САЛОН_БДDataSet;
            // 
            // данные_о_клиентахTableAdapter
            // 
            this.данные_о_клиентахTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = БД_СПА.СПА_САЛОН_БДDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Данные_о_клиентахTableAdapter = this.данные_о_клиентахTableAdapter;
            this.tableAdapterManager.Заказы_на_МартTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Таблица1TableAdapter = null;
            this.tableAdapterManager.ТоварыTableAdapter = null;
            // 
            // данные_о_клиентахBindingNavigator
            // 
            this.данные_о_клиентахBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.данные_о_клиентахBindingNavigator.BindingSource = this.данные_о_клиентахBindingSource;
            this.данные_о_клиентахBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.данные_о_клиентахBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.данные_о_клиентахBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.данные_о_клиентахBindingNavigatorSaveItem});
            this.данные_о_клиентахBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.данные_о_клиентахBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.данные_о_клиентахBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.данные_о_клиентахBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.данные_о_клиентахBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.данные_о_клиентахBindingNavigator.Name = "данные_о_клиентахBindingNavigator";
            this.данные_о_клиентахBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.данные_о_клиентахBindingNavigator.Size = new System.Drawing.Size(484, 25);
            this.данные_о_клиентахBindingNavigator.TabIndex = 3;
            this.данные_о_клиентахBindingNavigator.Text = "bindingNavigator1";
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
            // данные_о_клиентахBindingNavigatorSaveItem
            // 
            this.данные_о_клиентахBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.данные_о_клиентахBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("данные_о_клиентахBindingNavigatorSaveItem.Image")));
            this.данные_о_клиентахBindingNavigatorSaveItem.Name = "данные_о_клиентахBindingNavigatorSaveItem";
            this.данные_о_клиентахBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.данные_о_клиентахBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.данные_о_клиентахBindingNavigatorSaveItem.Click += new System.EventHandler(this.данные_о_клиентахBindingNavigatorSaveItem_Click);
            // 
            // сПА_САЛОН_БДDataSet1
            // 
            this.сПА_САЛОН_БДDataSet1.DataSetName = "СПА_САЛОН_БДDataSet1";
            this.сПА_САЛОН_БДDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // данные_о_клиентахBindingSource1
            // 
            this.данные_о_клиентахBindingSource1.DataMember = "Данные_о_клиентах";
            this.данные_о_клиентахBindingSource1.DataSource = this.сПА_САЛОН_БДDataSet1;
            // 
            // данные_о_клиентахTableAdapter1
            // 
            this.данные_о_клиентахTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = БД_СПА.СПА_САЛОН_БДDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.Данные_о_клиентахTableAdapter = this.данные_о_клиентахTableAdapter1;
            this.tableAdapterManager1.Заказы_на_МартTableAdapter = null;
            this.tableAdapterManager1.СотрудникиTableAdapter = null;
            this.tableAdapterManager1.Таблица1TableAdapter = null;
            this.tableAdapterManager1.ТоварыTableAdapter = null;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(347, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Конец";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(347, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Вперед";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(107, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Начало";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(107, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button7.Location = new System.Drawing.Point(10, 183);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 64);
            this.button7.TabIndex = 23;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button6.Location = new System.Drawing.Point(10, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 64);
            this.button6.TabIndex = 22;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.Location = new System.Drawing.Point(389, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_о_клиентахBindingSource, "ФИО", true));
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBox1.Location = new System.Drawing.Point(159, 75);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(316, 23);
            this.maskedTextBox1.TabIndex = 24;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_о_клиентахBindingSource, "Телефон", true));
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBox2.Location = new System.Drawing.Point(183, 105);
            this.maskedTextBox2.Mask = "+7 (999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(289, 23);
            this.maskedTextBox2.TabIndex = 25;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_о_клиентахBindingSource, "Email", true));
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBox3.Location = new System.Drawing.Point(157, 135);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(315, 23);
            this.maskedTextBox3.TabIndex = 26;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_о_клиентахBindingSource, "Адрес", true));
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBox4.Location = new System.Drawing.Point(163, 174);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(309, 23);
            this.maskedTextBox4.TabIndex = 27;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_о_клиентахBindingSource, "Дата_Регистрации", true));
            this.maskedTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBox5.Location = new System.Drawing.Point(244, 210);
            this.maskedTextBox5.Mask = "00/00/0000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(228, 23);
            this.maskedTextBox5.TabIndex = 28;
            this.maskedTextBox5.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_о_клиентахBindingSource, "Коментарий", true));
            this.maskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBox6.Location = new System.Drawing.Point(204, 239);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(268, 23);
            this.maskedTextBox6.TabIndex = 29;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(коментарийLabel);
            this.Controls.Add(дата_РегистрацииLabel);
            this.Controls.Add(адресLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.данные_о_клиентахBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Таблица \"Данные о клиентах\"";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сПА_САЛОН_БДDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_клиентахBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_клиентахBindingNavigator)).EndInit();
            this.данные_о_клиентахBindingNavigator.ResumeLayout(false);
            this.данные_о_клиентахBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сПА_САЛОН_БДDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.данные_о_клиентахBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private СПА_САЛОН_БДDataSet сПА_САЛОН_БДDataSet;
        private System.Windows.Forms.BindingSource данные_о_клиентахBindingSource;
        private СПА_САЛОН_БДDataSetTableAdapters.Данные_о_клиентахTableAdapter данные_о_клиентахTableAdapter;
        private СПА_САЛОН_БДDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator данные_о_клиентахBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton данные_о_клиентахBindingNavigatorSaveItem;
        private СПА_САЛОН_БДDataSet1 сПА_САЛОН_БДDataSet1;
        private System.Windows.Forms.BindingSource данные_о_клиентахBindingSource1;
        private СПА_САЛОН_БДDataSet1TableAdapters.Данные_о_клиентахTableAdapter данные_о_клиентахTableAdapter1;
        private СПА_САЛОН_БДDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
    }
}