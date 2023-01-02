namespace Lab_5_4_1
{
    partial class Execution
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
            this.NumberTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumResultTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Number2TB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ArrayResultTB = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FreqWordTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextResultTB = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DimensionTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MatrixTB = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NumbersTB = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AmountNTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberTB
            // 
            this.NumberTB.Location = new System.Drawing.Point(140, 50);
            this.NumberTB.Name = "NumberTB";
            this.NumberTB.Size = new System.Drawing.Size(569, 34);
            this.NumberTB.TabIndex = 2;
            this.NumberTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTB_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumResultTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Number2TB);
            this.groupBox1.Controls.Add(this.NumberTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задание №1:";
            // 
            // NumResultTB
            // 
            this.NumResultTB.Location = new System.Drawing.Point(140, 165);
            this.NumResultTB.Name = "NumResultTB";
            this.NumResultTB.ReadOnly = true;
            this.NumResultTB.Size = new System.Drawing.Size(569, 34);
            this.NumResultTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Число 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Число 1:";
            // 
            // Number2TB
            // 
            this.Number2TB.Location = new System.Drawing.Point(140, 109);
            this.Number2TB.Name = "Number2TB";
            this.Number2TB.Size = new System.Drawing.Size(569, 34);
            this.Number2TB.TabIndex = 3;
            this.Number2TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTB_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ArrayResultTB);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 143);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задание №2:";
            // 
            // ArrayResultTB
            // 
            this.ArrayResultTB.Location = new System.Drawing.Point(39, 33);
            this.ArrayResultTB.Name = "ArrayResultTB";
            this.ArrayResultTB.ReadOnly = true;
            this.ArrayResultTB.Size = new System.Drawing.Size(670, 96);
            this.ArrayResultTB.TabIndex = 0;
            this.ArrayResultTB.Text = "";
            this.ArrayResultTB.WordWrap = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.AmountTB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.FreqWordTB);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TextResultTB);
            this.groupBox3.Location = new System.Drawing.Point(12, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 237);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задание №3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Количество:";
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(554, 174);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.ReadOnly = true;
            this.AmountTB.Size = new System.Drawing.Size(155, 34);
            this.AmountTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Частое слово:";
            // 
            // FreqWordTB
            // 
            this.FreqWordTB.Location = new System.Drawing.Point(193, 174);
            this.FreqWordTB.Name = "FreqWordTB";
            this.FreqWordTB.ReadOnly = true;
            this.FreqWordTB.Size = new System.Drawing.Size(191, 34);
            this.FreqWordTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Текст:";
            // 
            // TextResultTB
            // 
            this.TextResultTB.Location = new System.Drawing.Point(39, 60);
            this.TextResultTB.Name = "TextResultTB";
            this.TextResultTB.ReadOnly = true;
            this.TextResultTB.Size = new System.Drawing.Size(670, 96);
            this.TextResultTB.TabIndex = 1;
            this.TextResultTB.Text = "";
            this.TextResultTB.WordWrap = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.DimensionTB);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.MaxTB);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.MinTB);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.MatrixTB);
            this.groupBox4.Location = new System.Drawing.Point(769, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(567, 364);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Задание №4:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(398, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 26);
            this.label11.TabIndex = 7;
            this.label11.Text = "Размерность:";
            // 
            // DimensionTB
            // 
            this.DimensionTB.Location = new System.Drawing.Point(437, 101);
            this.DimensionTB.Name = "DimensionTB";
            this.DimensionTB.Size = new System.Drawing.Size(109, 34);
            this.DimensionTB.TabIndex = 6;
            this.DimensionTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DimensionTB_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(419, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Максимум:";
            // 
            // MaxTB
            // 
            this.MaxTB.Location = new System.Drawing.Point(437, 288);
            this.MaxTB.Name = "MaxTB";
            this.MaxTB.ReadOnly = true;
            this.MaxTB.Size = new System.Drawing.Size(109, 34);
            this.MaxTB.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Минимум:";
            // 
            // MinTB
            // 
            this.MinTB.Location = new System.Drawing.Point(437, 179);
            this.MinTB.Name = "MinTB";
            this.MinTB.ReadOnly = true;
            this.MinTB.Size = new System.Drawing.Size(109, 34);
            this.MinTB.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Матрица:";
            // 
            // MatrixTB
            // 
            this.MatrixTB.Location = new System.Drawing.Point(36, 64);
            this.MatrixTB.Name = "MatrixTB";
            this.MatrixTB.ReadOnly = true;
            this.MatrixTB.Size = new System.Drawing.Size(352, 257);
            this.MatrixTB.TabIndex = 0;
            this.MatrixTB.Text = "";
            this.MatrixTB.WordWrap = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NumbersTB);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.AmountNTB);
            this.groupBox5.Location = new System.Drawing.Point(769, 392);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(567, 237);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Задание №5:";
            // 
            // NumbersTB
            // 
            this.NumbersTB.Location = new System.Drawing.Point(45, 115);
            this.NumbersTB.Name = "NumbersTB";
            this.NumbersTB.ReadOnly = true;
            this.NumbersTB.Size = new System.Drawing.Size(501, 96);
            this.NumbersTB.TabIndex = 8;
            this.NumbersTB.Text = "";
            this.NumbersTB.WordWrap = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 26);
            this.label10.TabIndex = 7;
            this.label10.Text = "Число n:";
            // 
            // AmountNTB
            // 
            this.AmountNTB.Location = new System.Drawing.Point(137, 48);
            this.AmountNTB.Name = "AmountNTB";
            this.AmountNTB.Size = new System.Drawing.Size(202, 34);
            this.AmountNTB.TabIndex = 6;
            this.AmountNTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DimensionTB_KeyPress);
            // 
            // Execution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 648);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Execution";
            this.Text = "Действия (2)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox NumberTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Number2TB;
        private System.Windows.Forms.TextBox NumResultTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox ArrayResultTB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FreqWordTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TextResultTB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MinTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox MatrixTB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox NumbersTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AmountNTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DimensionTB;
    }
}

