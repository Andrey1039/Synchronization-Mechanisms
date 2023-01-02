namespace Lab_1_3
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
            this.PrevPageBtn = new System.Windows.Forms.Button();
            this.NextPageBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FactorTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MulBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RowsTB = new System.Windows.Forms.TextBox();
            this.ShowMatrixBtn = new System.Windows.Forms.Button();
            this.ColumnsTB = new System.Windows.Forms.TextBox();
            this.GenMatrixBtn = new System.Windows.Forms.Button();
            this.MatrixTable = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PrevPageBtn
            // 
            this.PrevPageBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrevPageBtn.Location = new System.Drawing.Point(257, 265);
            this.PrevPageBtn.Name = "PrevPageBtn";
            this.PrevPageBtn.Size = new System.Drawing.Size(29, 56);
            this.PrevPageBtn.TabIndex = 15;
            this.PrevPageBtn.Text = "<";
            this.PrevPageBtn.UseVisualStyleBackColor = true;
            this.PrevPageBtn.Click += new System.EventHandler(this.PrevPageBtn_Click);
            // 
            // NextPageBtn
            // 
            this.NextPageBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextPageBtn.Location = new System.Drawing.Point(257, 185);
            this.NextPageBtn.Name = "NextPageBtn";
            this.NextPageBtn.Size = new System.Drawing.Size(29, 56);
            this.NextPageBtn.TabIndex = 14;
            this.NextPageBtn.Text = ">";
            this.NextPageBtn.UseVisualStyleBackColor = true;
            this.NextPageBtn.Click += new System.EventHandler(this.NextPageBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FactorTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MulBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RowsTB);
            this.groupBox1.Controls.Add(this.ShowMatrixBtn);
            this.groupBox1.Controls.Add(this.ColumnsTB);
            this.groupBox1.Controls.Add(this.GenMatrixBtn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 527);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия";
            // 
            // FactorTB
            // 
            this.FactorTB.Location = new System.Drawing.Point(11, 411);
            this.FactorTB.Multiline = true;
            this.FactorTB.Name = "FactorTB";
            this.FactorTB.Size = new System.Drawing.Size(208, 32);
            this.FactorTB.TabIndex = 9;
            this.FactorTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.FactorTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Множитель:";
            // 
            // MulBtn
            // 
            this.MulBtn.Location = new System.Drawing.Point(11, 458);
            this.MulBtn.Name = "MulBtn";
            this.MulBtn.Size = new System.Drawing.Size(212, 63);
            this.MulBtn.TabIndex = 7;
            this.MulBtn.Text = "Умножить";
            this.MulBtn.UseVisualStyleBackColor = true;
            this.MulBtn.Click += new System.EventHandler(this.MulBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Столбцы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Строки:";
            // 
            // RowsTB
            // 
            this.RowsTB.Location = new System.Drawing.Point(15, 66);
            this.RowsTB.Multiline = true;
            this.RowsTB.Name = "RowsTB";
            this.RowsTB.Size = new System.Drawing.Size(208, 32);
            this.RowsTB.TabIndex = 0;
            this.RowsTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.RowsTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ShowMatrixBtn
            // 
            this.ShowMatrixBtn.Location = new System.Drawing.Point(11, 298);
            this.ShowMatrixBtn.Name = "ShowMatrixBtn";
            this.ShowMatrixBtn.Size = new System.Drawing.Size(212, 67);
            this.ShowMatrixBtn.TabIndex = 4;
            this.ShowMatrixBtn.Text = "Показать матрицу";
            this.ShowMatrixBtn.UseVisualStyleBackColor = true;
            this.ShowMatrixBtn.Click += new System.EventHandler(this.ShowMatrixBtn_Click);
            // 
            // ColumnsTB
            // 
            this.ColumnsTB.Location = new System.Drawing.Point(15, 149);
            this.ColumnsTB.Multiline = true;
            this.ColumnsTB.Name = "ColumnsTB";
            this.ColumnsTB.Size = new System.Drawing.Size(208, 32);
            this.ColumnsTB.TabIndex = 1;
            this.ColumnsTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ColumnsTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // GenMatrixBtn
            // 
            this.GenMatrixBtn.Location = new System.Drawing.Point(11, 209);
            this.GenMatrixBtn.Name = "GenMatrixBtn";
            this.GenMatrixBtn.Size = new System.Drawing.Size(212, 71);
            this.GenMatrixBtn.TabIndex = 2;
            this.GenMatrixBtn.Text = "Сгенерировать матрицу";
            this.GenMatrixBtn.UseVisualStyleBackColor = true;
            this.GenMatrixBtn.Click += new System.EventHandler(this.GenMatrixBtn_Click);
            // 
            // MatrixTable
            // 
            this.MatrixTable.AllowUserToDeleteRows = false;
            this.MatrixTable.BackgroundColor = System.Drawing.Color.White;
            this.MatrixTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixTable.Location = new System.Drawing.Point(292, 12);
            this.MatrixTable.Name = "MatrixTable";
            this.MatrixTable.RowHeadersWidth = 100;
            this.MatrixTable.RowTemplate.Height = 24;
            this.MatrixTable.RowTemplate.ReadOnly = true;
            this.MatrixTable.Size = new System.Drawing.Size(636, 527);
            this.MatrixTable.TabIndex = 12;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 551);
            this.Controls.Add(this.PrevPageBtn);
            this.Controls.Add(this.NextPageBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MatrixTable);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Задание №3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrevPageBtn;
        private System.Windows.Forms.Button NextPageBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FactorTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MulBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RowsTB;
        private System.Windows.Forms.Button ShowMatrixBtn;
        private System.Windows.Forms.TextBox ColumnsTB;
        private System.Windows.Forms.Button GenMatrixBtn;
        private System.Windows.Forms.DataGridView MatrixTable;
    }
}

