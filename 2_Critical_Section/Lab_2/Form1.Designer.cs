namespace Lab_2_2
{
    partial class Module
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
            this.InputTextTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckSumTB = new System.Windows.Forms.TextBox();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.CharCodesTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextTB
            // 
            this.InputTextTB.Location = new System.Drawing.Point(68, 97);
            this.InputTextTB.Margin = new System.Windows.Forms.Padding(5);
            this.InputTextTB.Name = "InputTextTB";
            this.InputTextTB.Size = new System.Drawing.Size(820, 34);
            this.InputTextTB.TabIndex = 0;
            this.InputTextTB.TextChanged += new System.EventHandler(this.InputTextTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите строку:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Контрольная сумма:";
            // 
            // CheckSumTB
            // 
            this.CheckSumTB.Location = new System.Drawing.Point(72, 320);
            this.CheckSumTB.Name = "CheckSumTB";
            this.CheckSumTB.ReadOnly = true;
            this.CheckSumTB.Size = new System.Drawing.Size(820, 34);
            this.CheckSumTB.TabIndex = 3;
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Enabled = false;
            this.ExecuteBtn.Location = new System.Drawing.Point(334, 163);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(238, 61);
            this.ExecuteBtn.TabIndex = 4;
            this.ExecuteBtn.Text = "Вычислить";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // CharCodesTB
            // 
            this.CharCodesTB.Location = new System.Drawing.Point(72, 448);
            this.CharCodesTB.Multiline = true;
            this.CharCodesTB.Name = "CharCodesTB";
            this.CharCodesTB.ReadOnly = true;
            this.CharCodesTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CharCodesTB.Size = new System.Drawing.Size(820, 68);
            this.CharCodesTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Коды символов:";
            // 
            // Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 552);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CharCodesTB);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.CheckSumTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputTextTB);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Module";
            this.Text = "Задание №2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CheckSumTB;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.TextBox CharCodesTB;
        private System.Windows.Forms.Label label3;
    }
}

