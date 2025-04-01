namespace bank
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_TypeOperation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Sum = new System.Windows.Forms.TextBox();
            this.button_AddTransaction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Balance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новая операция ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип операции";
            // 
            // comboBox_TypeOperation
            // 
            this.comboBox_TypeOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_TypeOperation.FormattingEnabled = true;
            this.comboBox_TypeOperation.Items.AddRange(new object[] {
            "Пополнение",
            "Перевод средств",
            "Снятие средств"});
            this.comboBox_TypeOperation.Location = new System.Drawing.Point(192, 77);
            this.comboBox_TypeOperation.Name = "comboBox_TypeOperation";
            this.comboBox_TypeOperation.Size = new System.Drawing.Size(177, 33);
            this.comboBox_TypeOperation.TabIndex = 2;
            this.comboBox_TypeOperation.SelectedIndexChanged += new System.EventHandler(this.comboBox_TypeOperation_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Сумма";
            // 
            // textBox_Sum
            // 
            this.textBox_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Sum.Location = new System.Drawing.Point(192, 132);
            this.textBox_Sum.Name = "textBox_Sum";
            this.textBox_Sum.Size = new System.Drawing.Size(177, 30);
            this.textBox_Sum.TabIndex = 4;
            this.textBox_Sum.TextChanged += new System.EventHandler(this.textBox_Sum_TextChanged);
            // 
            // button_AddTransaction
            // 
            this.button_AddTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddTransaction.Location = new System.Drawing.Point(12, 180);
            this.button_AddTransaction.Name = "button_AddTransaction";
            this.button_AddTransaction.Size = new System.Drawing.Size(146, 57);
            this.button_AddTransaction.TabIndex = 5;
            this.button_AddTransaction.Text = "Добавить операцию";
            this.button_AddTransaction.UseVisualStyleBackColor = true;
            this.button_AddTransaction.Click += new System.EventHandler(this.button_AddTransaction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(240, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Баланс";
            // 
            // textBox_Balance
            // 
            this.textBox_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Balance.Location = new System.Drawing.Point(192, 208);
            this.textBox_Balance.Name = "textBox_Balance";
            this.textBox_Balance.Size = new System.Drawing.Size(177, 30);
            this.textBox_Balance.TabIndex = 7;
            this.textBox_Balance.TextChanged += new System.EventHandler(this.textBox_Balance_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(389, 266);
            this.Controls.Add(this.textBox_Balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_AddTransaction);
            this.Controls.Add(this.textBox_Sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_TypeOperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_TypeOperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Sum;
        private System.Windows.Forms.Button button_AddTransaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Balance;
    }
}