namespace Lab_1_4
{
    partial class MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.Thread3Box = new System.Windows.Forms.ComboBox();
            this.Thread2Box = new System.Windows.Forms.ComboBox();
            this.Thread1Box = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RestartBtn);
            this.groupBox1.Controls.Add(this.StopBtn);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Controls.Add(this.Thread3Box);
            this.groupBox1.Controls.Add(this.Thread2Box);
            this.groupBox1.Controls.Add(this.Thread1Box);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Приоритет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поток №3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поток №2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поток №1:";
            // 
            // RestartBtn
            // 
            this.RestartBtn.Location = new System.Drawing.Point(6, 461);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(203, 34);
            this.RestartBtn.TabIndex = 5;
            this.RestartBtn.Text = "Рестарт";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(6, 394);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(203, 41);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "Стоп";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(6, 328);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(203, 41);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Старт";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Thread3Box
            // 
            this.Thread3Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Thread3Box.FormattingEnabled = true;
            this.Thread3Box.Location = new System.Drawing.Point(6, 261);
            this.Thread3Box.Name = "Thread3Box";
            this.Thread3Box.Size = new System.Drawing.Size(203, 34);
            this.Thread3Box.TabIndex = 2;
            this.Thread3Box.SelectedIndexChanged += new System.EventHandler(this.ThreadBox_SelectedIndexChanged);
            // 
            // Thread2Box
            // 
            this.Thread2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Thread2Box.FormattingEnabled = true;
            this.Thread2Box.Location = new System.Drawing.Point(6, 173);
            this.Thread2Box.Name = "Thread2Box";
            this.Thread2Box.Size = new System.Drawing.Size(203, 34);
            this.Thread2Box.TabIndex = 1;
            this.Thread2Box.SelectedIndexChanged += new System.EventHandler(this.ThreadBox_SelectedIndexChanged);
            // 
            // Thread1Box
            // 
            this.Thread1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Thread1Box.FormattingEnabled = true;
            this.Thread1Box.Location = new System.Drawing.Point(6, 78);
            this.Thread1Box.Name = "Thread1Box";
            this.Thread1Box.Size = new System.Drawing.Size(203, 34);
            this.Thread1Box.TabIndex = 0;
            this.Thread1Box.SelectedIndexChanged += new System.EventHandler(this.ThreadBox_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 592);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "Задание №4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Thread3Box;
        private System.Windows.Forms.ComboBox Thread2Box;
        private System.Windows.Forms.ComboBox Thread1Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button StartBtn;
    }
}

