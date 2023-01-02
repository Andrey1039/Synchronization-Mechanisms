using System;
using System.Threading;
using System.Windows.Forms;

namespace Lab_1_3
{
    public partial class MainWindow : Form
    {
        double[,] mass;
        Random r;
        int n = 0;
        int m = 0;
        int pos = 0;

        public MainWindow()
        {
            InitializeComponent();
            r = new Random();
        }

        // Заполнение матрицы случайными числами
        public void Create(int i)
        {
            for (int j = 0; j < m; j++)
            {
                int t = j;
                mass[i, t] = r.Next(Width);
            }
        }

        // Параллельное заполнение строк матрицы
        private void GenMatrix()
        {
            Thread[] hThread = new Thread[n];
            for (int i = 0; i < n; i++)
            {
                int temp = i;
                hThread[temp] = new Thread(x => Create(temp));
                hThread[temp].Start();

                hThread[temp].Join();
            }
        }

        private void GenMatrixBtn_Click(object sender, EventArgs e)
        {
            pos = 0;
            n = int.Parse(RowsTB.Text);
            m = int.Parse(ColumnsTB.Text);
            mass = new double[n, m];

            GenMatrix();
        }

        // Очистка таблицы
        public void Clean()
        {
            MatrixTable.DataSource = null;
            MatrixTable.Rows.Clear();
            MatrixTable.Columns.Clear();
        }

        // Создание таблицы для матрицы
        public void CreateTable()
        {
            Clean();

            DataGridViewColumn column;
            for (int i = pos; (i < m) && (i < pos + 100); i++)
            {
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = $"[{i + 1}]";
                column.Name = $"[{i + 1}]";
                MatrixTable.Columns.Add(column);
            }

            for (int i = 0; i < n; i++)
            {
                MatrixTable.Rows.Add();
                MatrixTable.Rows[i].HeaderCell.Value = $"[{i + 1}]";
            }
        }

        // Вывод матрицы на экран
        public void Print(int i)
        {
            int k = 0;
            for (int j = pos; (j < m) && (j < pos + 100); j++)
            {
                MatrixTable.Rows[i].Cells[k].Value = mass[i, j];
                k++;
            }
        }

        // Вывод матрицы на экран
        private void ShowMatrix()
        {
            Thread[] hThread1 = new Thread[n];
            for (int i = 0; i < n; i++)
            {
                int temp2 = i;
                hThread1[temp2] = new Thread(x => Print(temp2));
                hThread1[temp2].Start();

                hThread1[temp2].Join();
            }
        }

        private void ShowMatrixBtn_Click(object sender, EventArgs e)
        {
            CreateTable();
            ShowMatrix();
        }
        
        // Переключение страниц - следующая
        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            int temp = pos;
            pos = pos <= m ? pos += 100 : pos = temp;

            if (pos < m)
            {
                CreateTable();
                ShowMatrix();
            }
            else
            {
                pos -= 100;
                MessageBox.Show("Вы достигли конца матрицы!");
            }
        }

        // Переключение страниц - предыдущая
        private void PrevPageBtn_Click(object sender, EventArgs e)
        {
            pos = pos >= 0 ? pos -= 100 : pos = 0;

            if (pos >= 0)
            {
                CreateTable();
                ShowMatrix();
            }
            else
            {
                MessageBox.Show("Вы достигли начала матрицы!");
                pos += 100;
            }
        }

        // Умножение матрицы на число
        public void Mul(int i, int num)
        {
            for (int j = 0; j < m; j++)
                mass[i, j] *= num;
        }

        private void MulBtn_Click(object sender, EventArgs e)
        {
            Thread[] hThread2 = new Thread[n];
            int num = int.Parse(FactorTB.Text);

            for (int i = 0; i < n; i++)
            {
                int temp = i;
                hThread2[temp] = new Thread(x => Mul(temp, num));
                hThread2[temp].Start();

                hThread2[temp].Join();
            }

            ShowMatrixBtn_Click(null, null);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Clean();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                return;
            }
            else e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '-' || e.KeyChar == ',')
            {
                return;
            }
            else e.Handled = true;
        }
    }
}
