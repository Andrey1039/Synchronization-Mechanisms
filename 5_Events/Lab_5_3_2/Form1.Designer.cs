namespace Lab_5_4_2
{
    partial class Actions
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Action5 = new System.Windows.Forms.CheckBox();
            this.Action4 = new System.Windows.Forms.CheckBox();
            this.Action3 = new System.Windows.Forms.CheckBox();
            this.Action2 = new System.Windows.Forms.CheckBox();
            this.Action1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(352, 412);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(5);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(160, 37);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Выполнить";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Action5);
            this.groupBox1.Controls.Add(this.Action4);
            this.groupBox1.Controls.Add(this.Action3);
            this.groupBox1.Controls.Add(this.Action2);
            this.groupBox1.Controls.Add(this.Action1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(838, 373);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия:";
            // 
            // Action5
            // 
            this.Action5.Location = new System.Drawing.Point(63, 296);
            this.Action5.Name = "Action5";
            this.Action5.Size = new System.Drawing.Size(726, 66);
            this.Action5.TabIndex = 7;
            this.Action5.Text = "5. Вывести все простые числа от 0 до n, используя алгоритм «Решето Эратосфена»";
            this.Action5.UseVisualStyleBackColor = true;
            // 
            // Action4
            // 
            this.Action4.Location = new System.Drawing.Point(63, 197);
            this.Action4.Name = "Action4";
            this.Action4.Size = new System.Drawing.Size(754, 93);
            this.Action4.TabIndex = 6;
            this.Action4.Text = "4. Вывести минимальный элемент среди элементов, расположенных ниже главной диагон" +
    "али, и максимальный элемент, среди элементов расположенных выше побочной диагона" +
    "ли квадратной матрицы размером nxn";
            this.Action4.UseVisualStyleBackColor = true;
            // 
            // Action3
            // 
            this.Action3.Location = new System.Drawing.Point(63, 130);
            this.Action3.Name = "Action3";
            this.Action3.Size = new System.Drawing.Size(754, 61);
            this.Action3.TabIndex = 5;
            this.Action3.Text = "3. Вывести самое часто встречающееся слово в тексте и количество вхождений";
            this.Action3.UseVisualStyleBackColor = true;
            // 
            // Action2
            // 
            this.Action2.Location = new System.Drawing.Point(63, 84);
            this.Action2.Name = "Action2";
            this.Action2.Size = new System.Drawing.Size(694, 40);
            this.Action2.TabIndex = 4;
            this.Action2.Text = "2. Удалить из массива вещественных чисел дубликаты";
            this.Action2.UseVisualStyleBackColor = true;
            // 
            // Action1
            // 
            this.Action1.Location = new System.Drawing.Point(63, 35);
            this.Action1.Name = "Action1";
            this.Action1.Size = new System.Drawing.Size(744, 43);
            this.Action1.TabIndex = 3;
            this.Action1.Text = "1. Перемножить 2 больших числа";
            this.Action1.UseVisualStyleBackColor = true;
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StartBtn);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Actions";
            this.Text = "Выбор действий (1)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Actions_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Action5;
        private System.Windows.Forms.CheckBox Action4;
        private System.Windows.Forms.CheckBox Action3;
        private System.Windows.Forms.CheckBox Action2;
        private System.Windows.Forms.CheckBox Action1;
    }
}

