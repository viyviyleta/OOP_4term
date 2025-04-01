namespace bank
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_accounts = new System.Windows.Forms.ListBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnDownloud = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Information = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type_Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalculateBudget = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНомеруСчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВладельцуФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поРегулярномуВыражениюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширенныйПоискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поБалансуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеОткрытияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПоискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСортировкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.поНомеруПоспортуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширенныйПоискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.поБалансуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеОткрытияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripSplitButton();
            this.сверхуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снизуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрытьОтобразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Банк";
            // 
            // listBox_accounts
            // 
            this.listBox_accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_accounts.FormattingEnabled = true;
            this.listBox_accounts.HorizontalScrollbar = true;
            this.listBox_accounts.ItemHeight = 16;
            this.listBox_accounts.Location = new System.Drawing.Point(12, 101);
            this.listBox_accounts.Name = "listBox_accounts";
            this.listBox_accounts.Size = new System.Drawing.Size(193, 228);
            this.listBox_accounts.TabIndex = 1;
            this.listBox_accounts.SelectedIndexChanged += new System.EventHandler(this.listBox_accounts_SelectedIndexChanged);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(211, 101);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(132, 52);
            this.btnAddAccount.TabIndex = 2;
            this.btnAddAccount.Text = "Добавить пользователя";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(211, 161);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(132, 52);
            this.btnAddTransaction.TabIndex = 3;
            this.btnAddTransaction.Text = "Добавить операцию";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(211, 219);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(132, 52);
            this.btnInformation.TabIndex = 4;
            this.btnInformation.Text = "Информация о пользователе";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(211, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 52);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалиить информацию";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(12, 335);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(152, 52);
            this.btnSaveToFile.TabIndex = 6;
            this.btnSaveToFile.Text = "Сохранить информацию";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnDownloud
            // 
            this.btnDownloud.Location = new System.Drawing.Point(191, 335);
            this.btnDownloud.Name = "btnDownloud";
            this.btnDownloud.Size = new System.Drawing.Size(152, 52);
            this.btnDownloud.TabIndex = 7;
            this.btnDownloud.Text = "Загрузить информацию";
            this.btnDownloud.UseVisualStyleBackColor = true;
            this.btnDownloud.Click += new System.EventHandler(this.btnDownloud_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(446, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Информация о пользователе";
            // 
            // textBox_Information
            // 
            this.textBox_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Information.Location = new System.Drawing.Point(366, 99);
            this.textBox_Information.Multiline = true;
            this.textBox_Information.Name = "textBox_Information";
            this.textBox_Information.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Information.Size = new System.Drawing.Size(521, 99);
            this.textBox_Information.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(511, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "История операций ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type_Operation,
            this.Sum,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(366, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(521, 84);
            this.dataGridView1.TabIndex = 11;
            // 
            // Type_Operation
            // 
            this.Type_Operation.Frozen = true;
            this.Type_Operation.HeaderText = "Тип операции";
            this.Type_Operation.MinimumWidth = 6;
            this.Type_Operation.Name = "Type_Operation";
            this.Type_Operation.ReadOnly = true;
            this.Type_Operation.Width = 125;
            // 
            // Sum
            // 
            this.Sum.Frozen = true;
            this.Sum.HeaderText = "Сумма";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 125;
            // 
            // Date
            // 
            this.Date.Frozen = true;
            this.Date.HeaderText = "Дата операции ";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // btnCalculateBudget
            // 
            this.btnCalculateBudget.Location = new System.Drawing.Point(366, 335);
            this.btnCalculateBudget.Name = "btnCalculateBudget";
            this.btnCalculateBudget.Size = new System.Drawing.Size(152, 52);
            this.btnCalculateBudget.TabIndex = 12;
            this.btnCalculateBudget.Tag = "";
            this.btnCalculateBudget.Text = "Рассчитать бюджет пользователя";
            this.btnCalculateBudget.UseVisualStyleBackColor = true;
            this.btnCalculateBudget.Click += new System.EventHandler(this.btnCalculateBudget_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(542, 335);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 49);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Баланс + Поплнение - Расход";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.скрытьОтобразитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруСчетаToolStripMenuItem,
            this.поВладельцуФИОToolStripMenuItem,
            this.поРегулярномуВыражениюToolStripMenuItem,
            this.расширенныйПоискToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поНомеруСчетаToolStripMenuItem
            // 
            this.поНомеруСчетаToolStripMenuItem.Name = "поНомеруСчетаToolStripMenuItem";
            this.поНомеруСчетаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.поНомеруСчетаToolStripMenuItem.Text = "По номеру счета";
            this.поНомеруСчетаToolStripMenuItem.Click += new System.EventHandler(this.поНомеруСчетаToolStripMenuItem_Click);
            // 
            // поВладельцуФИОToolStripMenuItem
            // 
            this.поВладельцуФИОToolStripMenuItem.Name = "поВладельцуФИОToolStripMenuItem";
            this.поВладельцуФИОToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.поВладельцуФИОToolStripMenuItem.Text = "По владельцу (ФИО)";
            this.поВладельцуФИОToolStripMenuItem.Click += new System.EventHandler(this.поВладельцуФИОToolStripMenuItem_Click);
            // 
            // поРегулярномуВыражениюToolStripMenuItem
            // 
            this.поРегулярномуВыражениюToolStripMenuItem.Name = "поРегулярномуВыражениюToolStripMenuItem";
            this.поРегулярномуВыражениюToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.поРегулярномуВыражениюToolStripMenuItem.Text = "По номеру паспорта ";
            this.поРегулярномуВыражениюToolStripMenuItem.Click += new System.EventHandler(this.поРегулярномуВыражениюToolStripMenuItem_Click);
            // 
            // расширенныйПоискToolStripMenuItem
            // 
            this.расширенныйПоискToolStripMenuItem.Name = "расширенныйПоискToolStripMenuItem";
            this.расширенныйПоискToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.расширенныйПоискToolStripMenuItem.Text = "Расширенный поиск";
            this.расширенныйПоискToolStripMenuItem.Click += new System.EventHandler(this.расширенныйПоискToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поБалансуToolStripMenuItem,
            this.поДатеОткрытияToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поБалансуToolStripMenuItem
            // 
            this.поБалансуToolStripMenuItem.Name = "поБалансуToolStripMenuItem";
            this.поБалансуToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.поБалансуToolStripMenuItem.Text = "По балансу";
            this.поБалансуToolStripMenuItem.Click += new System.EventHandler(this.поБалансуToolStripMenuItem_Click);
            // 
            // поДатеОткрытияToolStripMenuItem
            // 
            this.поДатеОткрытияToolStripMenuItem.Name = "поДатеОткрытияToolStripMenuItem";
            this.поДатеОткрытияToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.поДатеОткрытияToolStripMenuItem.Text = "По дате открытия";
            this.поДатеОткрытияToolStripMenuItem.Click += new System.EventHandler(this.поДатеОткрытияToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьПоискToolStripMenuItem,
            this.сохранитьСортировкуToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить ";
            // 
            // сохранитьПоискToolStripMenuItem
            // 
            this.сохранитьПоискToolStripMenuItem.Name = "сохранитьПоискToolStripMenuItem";
            this.сохранитьПоискToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.сохранитьПоискToolStripMenuItem.Text = "Сохранить поиск";
            this.сохранитьПоискToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПоискToolStripMenuItem_Click);
            // 
            // сохранитьСортировкуToolStripMenuItem
            // 
            this.сохранитьСортировкуToolStripMenuItem.Name = "сохранитьСортировкуToolStripMenuItem";
            this.сохранитьСортировкуToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.сохранитьСортировкуToolStripMenuItem.Text = "Сохранить сортировку";
            this.сохранитьСортировкуToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСортировкуToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(915, 26);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(915, 27);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруПоспортуToolStripMenuItem,
            this.поискПоФИОToolStripMenuItem,
            this.расширенныйПоискToolStripMenuItem1});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(91, 24);
            this.toolStripSplitButton1.Text = "Поиск";
            // 
            // поНомеруПоспортуToolStripMenuItem
            // 
            this.поНомеруПоспортуToolStripMenuItem.Name = "поНомеруПоспортуToolStripMenuItem";
            this.поНомеруПоспортуToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.поНомеруПоспортуToolStripMenuItem.Text = "по номеру поспорта";
            this.поНомеруПоспортуToolStripMenuItem.Click += new System.EventHandler(this.поНомеруПоспортуToolStripMenuItem_Click);
            // 
            // поискПоФИОToolStripMenuItem
            // 
            this.поискПоФИОToolStripMenuItem.Name = "поискПоФИОToolStripMenuItem";
            this.поискПоФИОToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.поискПоФИОToolStripMenuItem.Text = "поиск по ФИО";
            this.поискПоФИОToolStripMenuItem.Click += new System.EventHandler(this.поискПоФИОToolStripMenuItem_Click);
            // 
            // расширенныйПоискToolStripMenuItem1
            // 
            this.расширенныйПоискToolStripMenuItem1.Name = "расширенныйПоискToolStripMenuItem1";
            this.расширенныйПоискToolStripMenuItem1.Size = new System.Drawing.Size(237, 26);
            this.расширенныйПоискToolStripMenuItem1.Text = "расширенный поиск";
            this.расширенныйПоискToolStripMenuItem1.Click += new System.EventHandler(this.расширенныйПоискToolStripMenuItem1_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поБалансуToolStripMenuItem1,
            this.поДатеОткрытияToolStripMenuItem1});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(131, 24);
            this.toolStripSplitButton2.Text = "Сортировка";
            // 
            // поБалансуToolStripMenuItem1
            // 
            this.поБалансуToolStripMenuItem1.Name = "поБалансуToolStripMenuItem1";
            this.поБалансуToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.поБалансуToolStripMenuItem1.Text = "по балансу";
            this.поБалансуToolStripMenuItem1.Click += new System.EventHandler(this.поБалансуToolStripMenuItem1_Click);
            // 
            // поДатеОткрытияToolStripMenuItem1
            // 
            this.поДатеОткрытияToolStripMenuItem1.Name = "поДатеОткрытияToolStripMenuItem1";
            this.поДатеОткрытияToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.поДатеОткрытияToolStripMenuItem1.Text = "по дате открытия";
            this.поДатеОткрытияToolStripMenuItem1.Click += new System.EventHandler(this.поДатеОткрытияToolStripMenuItem1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 24);
            this.toolStripButton1.Text = "Очистить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(89, 24);
            this.toolStripButton2.Text = "Удалить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(84, 24);
            this.toolStripButton3.Text = "Вперед";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(75, 24);
            this.toolStripButton4.Text = "Назад";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сверхуToolStripMenuItem,
            this.слеваToolStripMenuItem,
            this.справаToolStripMenuItem,
            this.снизуToolStripMenuItem});
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(120, 24);
            this.toolStripButton6.Text = "Закрепить";
            // 
            // сверхуToolStripMenuItem
            // 
            this.сверхуToolStripMenuItem.Name = "сверхуToolStripMenuItem";
            this.сверхуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сверхуToolStripMenuItem.Text = "Сверху";
            this.сверхуToolStripMenuItem.Click += new System.EventHandler(this.сверхуToolStripMenuItem_Click);
            // 
            // слеваToolStripMenuItem
            // 
            this.слеваToolStripMenuItem.Name = "слеваToolStripMenuItem";
            this.слеваToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.слеваToolStripMenuItem.Text = "Слева";
            this.слеваToolStripMenuItem.Click += new System.EventHandler(this.слеваToolStripMenuItem_Click);
            // 
            // справаToolStripMenuItem
            // 
            this.справаToolStripMenuItem.Name = "справаToolStripMenuItem";
            this.справаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.справаToolStripMenuItem.Text = "Справа";
            this.справаToolStripMenuItem.Click += new System.EventHandler(this.справаToolStripMenuItem_Click);
            // 
            // снизуToolStripMenuItem
            // 
            this.снизуToolStripMenuItem.Name = "снизуToolStripMenuItem";
            this.снизуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.снизуToolStripMenuItem.Text = "Снизу";
            this.снизуToolStripMenuItem.Click += new System.EventHandler(this.снизуToolStripMenuItem_Click);
            // 
            // скрытьОтобразитьToolStripMenuItem
            // 
            this.скрытьОтобразитьToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.скрытьОтобразитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("скрытьОтобразитьToolStripMenuItem.Image")));
            this.скрытьОтобразитьToolStripMenuItem.Name = "скрытьОтобразитьToolStripMenuItem";
            this.скрытьОтобразитьToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.скрытьОтобразитьToolStripMenuItem.Text = "Скрыть/Отобразить";
            this.скрытьОтобразитьToolStripMenuItem.Click += new System.EventHandler(this.скрытьОтобразитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(915, 426);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalculateBudget);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Information);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDownloud);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.listBox_accounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_accounts;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnDownloud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Information;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button btnCalculateBudget;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНомеруСчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВладельцуФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поРегулярномуВыражениюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширенныйПоискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поБалансуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеОткрытияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПоискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСортировкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem поискПоФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширенныйПоискToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem поБалансуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поДатеОткрытияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem поНомеруПоспортуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скрытьОтобразитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton6;
        private System.Windows.Forms.ToolStripMenuItem сверхуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слеваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снизуToolStripMenuItem;
    }
}

