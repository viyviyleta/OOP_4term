namespace MaterialCalculator
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
            this.Lengthtxt = new System.Windows.Forms.Label();
            this.LengthRoom = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.Label();
            this.WidthRoom = new System.Windows.Forms.TextBox();
            this.Hieght = new System.Windows.Forms.Label();
            this.HieghtRoom = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.Label();
            this.comboBoxMatirial = new System.Windows.Forms.ComboBox();
            this.sizeMatirial = new System.Windows.Forms.Label();
            this.MaterialSize = new System.Windows.Forms.TextBox();
            this.metr = new System.Windows.Forms.Button();
            this.feet = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lengthtxt
            // 
            this.Lengthtxt.AutoSize = true;
            this.Lengthtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lengthtxt.Location = new System.Drawing.Point(12, 27);
            this.Lengthtxt.Name = "Lengthtxt";
            this.Lengthtxt.Size = new System.Drawing.Size(197, 29);
            this.Lengthtxt.TabIndex = 0;
            this.Lengthtxt.Text = "Длина комнаты";
            this.Lengthtxt.Click += new System.EventHandler(this.Lengthtxt_Click);
            // 
            // LengthRoom
            // 
            this.LengthRoom.BackColor = System.Drawing.Color.White;
            this.LengthRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthRoom.Location = new System.Drawing.Point(255, 20);
            this.LengthRoom.Name = "LengthRoom";
            this.LengthRoom.Size = new System.Drawing.Size(150, 36);
            this.LengthRoom.TabIndex = 1;
            this.LengthRoom.TextChanged += new System.EventHandler(this.LengthRoom_TextChanged);
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Width.Location = new System.Drawing.Point(12, 85);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(214, 29);
            this.Width.TabIndex = 2;
            this.Width.Text = "Ширина комнаты";
            this.Width.Click += new System.EventHandler(this.label1_Click);
            // 
            // WidthRoom
            // 
            this.WidthRoom.BackColor = System.Drawing.Color.White;
            this.WidthRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthRoom.Location = new System.Drawing.Point(255, 78);
            this.WidthRoom.Name = "WidthRoom";
            this.WidthRoom.Size = new System.Drawing.Size(150, 36);
            this.WidthRoom.TabIndex = 3;
            this.WidthRoom.TextChanged += new System.EventHandler(this.WidthRoom_TextChanged);
            // 
            // Hieght
            // 
            this.Hieght.AutoSize = true;
            this.Hieght.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hieght.Location = new System.Drawing.Point(12, 143);
            this.Hieght.Name = "Hieght";
            this.Hieght.Size = new System.Drawing.Size(209, 29);
            this.Hieght.TabIndex = 4;
            this.Hieght.Text = "Высота комнаты";
            this.Hieght.Click += new System.EventHandler(this.Hieght_Click);
            // 
            // HieghtRoom
            // 
            this.HieghtRoom.BackColor = System.Drawing.Color.White;
            this.HieghtRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HieghtRoom.Location = new System.Drawing.Point(255, 136);
            this.HieghtRoom.Name = "HieghtRoom";
            this.HieghtRoom.Size = new System.Drawing.Size(150, 36);
            this.HieghtRoom.TabIndex = 5;
            this.HieghtRoom.TextChanged += new System.EventHandler(this.HieghtRoom_TextChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.Location = new System.Drawing.Point(12, 200);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(224, 29);
            this.checkBox.TabIndex = 6;
            this.checkBox.Text = "Выбор материала";
            this.checkBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // comboBoxMatirial
            // 
            this.comboBoxMatirial.BackColor = System.Drawing.Color.White;
            this.comboBoxMatirial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMatirial.FormattingEnabled = true;
            this.comboBoxMatirial.Items.AddRange(new object[] {
            "Обои",
            "Ламинат",
            "Плитка"});
            this.comboBoxMatirial.Location = new System.Drawing.Point(255, 197);
            this.comboBoxMatirial.Name = "comboBoxMatirial";
            this.comboBoxMatirial.Size = new System.Drawing.Size(150, 37);
            this.comboBoxMatirial.TabIndex = 7;
            this.comboBoxMatirial.SelectedIndexChanged += new System.EventHandler(this.comboBoxMatirial_SelectedIndexChanged);
            // 
            // sizeMatirial
            // 
            this.sizeMatirial.AutoSize = true;
            this.sizeMatirial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeMatirial.Location = new System.Drawing.Point(12, 268);
            this.sizeMatirial.Name = "sizeMatirial";
            this.sizeMatirial.Size = new System.Drawing.Size(223, 29);
            this.sizeMatirial.TabIndex = 8;
            this.sizeMatirial.Text = "Размер материла";
            // 
            // MaterialSize
            // 
            this.MaterialSize.BackColor = System.Drawing.Color.White;
            this.MaterialSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialSize.Location = new System.Drawing.Point(255, 261);
            this.MaterialSize.Name = "MaterialSize";
            this.MaterialSize.Size = new System.Drawing.Size(150, 36);
            this.MaterialSize.TabIndex = 9;
            this.MaterialSize.TextChanged += new System.EventHandler(this.MaterialSize_TextChanged);
            // 
            // metr
            // 
            this.metr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metr.Location = new System.Drawing.Point(41, 321);
            this.metr.Name = "metr";
            this.metr.Size = new System.Drawing.Size(155, 47);
            this.metr.TabIndex = 10;
            this.metr.Text = "кв м";
            this.metr.UseVisualStyleBackColor = true;
            this.metr.Click += new System.EventHandler(this.metr_Click);
            // 
            // feet
            // 
            this.feet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feet.Location = new System.Drawing.Point(236, 321);
            this.feet.Name = "feet";
            this.feet.Size = new System.Drawing.Size(155, 47);
            this.feet.TabIndex = 11;
            this.feet.Text = "футы";
            this.feet.UseVisualStyleBackColor = true;
            this.feet.Click += new System.EventHandler(this.feet_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.White;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(139, 389);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(150, 36);
            this.result.TabIndex = 12;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.feet);
            this.Controls.Add(this.metr);
            this.Controls.Add(this.MaterialSize);
            this.Controls.Add(this.sizeMatirial);
            this.Controls.Add(this.comboBoxMatirial);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.HieghtRoom);
            this.Controls.Add(this.Hieght);
            this.Controls.Add(this.WidthRoom);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.LengthRoom);
            this.Controls.Add(this.Lengthtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lengthtxt;
        private System.Windows.Forms.TextBox LengthRoom;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.TextBox WidthRoom;
        private System.Windows.Forms.Label Hieght;
        private System.Windows.Forms.TextBox HieghtRoom;
        private System.Windows.Forms.Label checkBox;
        private System.Windows.Forms.ComboBox comboBoxMatirial;
        private System.Windows.Forms.Label sizeMatirial;
        private System.Windows.Forms.TextBox MaterialSize;
        private System.Windows.Forms.Button metr;
        private System.Windows.Forms.Button feet;
        private System.Windows.Forms.TextBox result;
    }
}

