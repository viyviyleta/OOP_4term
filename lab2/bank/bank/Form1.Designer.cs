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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(149, 9);
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
            this.listBox_accounts.Location = new System.Drawing.Point(12, 41);
            this.listBox_accounts.Name = "listBox_accounts";
            this.listBox_accounts.Size = new System.Drawing.Size(193, 228);
            this.listBox_accounts.TabIndex = 1;
            this.listBox_accounts.SelectedIndexChanged += new System.EventHandler(this.listBox_accounts_SelectedIndexChanged);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(211, 41);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(132, 52);
            this.btnAddAccount.TabIndex = 2;
            this.btnAddAccount.Text = "Добавить пользователя";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(211, 99);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(132, 52);
            this.btnAddTransaction.TabIndex = 3;
            this.btnAddTransaction.Text = "Добавить операцию";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(211, 157);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(132, 52);
            this.btnInformation.TabIndex = 4;
            this.btnInformation.Text = "Информация о пользователе";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(211, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 52);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалиить информацию";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(12, 281);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(152, 52);
            this.btnSaveToFile.TabIndex = 6;
            this.btnSaveToFile.Text = "Сохранить информацию";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnDownloud
            // 
            this.btnDownloud.Location = new System.Drawing.Point(191, 281);
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
            this.label2.Location = new System.Drawing.Point(445, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Информация о пользователе";
            // 
            // textBox_Information
            // 
            this.textBox_Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Information.Location = new System.Drawing.Point(366, 52);
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
            this.label3.Location = new System.Drawing.Point(514, 151);
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
            this.dataGridView1.Location = new System.Drawing.Point(366, 183);
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
            this.btnCalculateBudget.Location = new System.Drawing.Point(366, 281);
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
            this.textBox1.Location = new System.Drawing.Point(542, 283);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 49);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Баланс + Поплнение - Расход";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(915, 353);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

