using System;
using System.Threading;
using System.Windows.Forms;

namespace Lab_2_2
{
    public partial class Module : Form
    {        
        private int sum = 0;       
        private static object locker;

        public Module()
        {
            InitializeComponent();
            locker = new object();
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            int n = InputTextTB.Text.Length;
            string text = InputTextTB.Text;
            CharCodesTB.Text = string.Empty;

            Random rand = new Random();
            int k = rand.Next(1, text.Length);
            Thread[] hThread = new Thread[k];

            for (int i = 0; i < n; i++)
                CharCodesTB.Text += $"{(int)text[i]} ";

            sum = 0;
            for (int i = 0; i < k; i++)
            {
                int temp = i;
                hThread[temp] = new Thread(x => Sum(temp, k, n, text));
                hThread[temp].Start();
            }

            for (int i = 0; i < k; i++)
                hThread[i].Join();

            CheckSumTB.Text = $"{sum % 256}";
        }

        // Подсчет суммы символов
        public void Sum(int i, int k, int n, string text)
        {
            for (int j = 0; i + k * j < n; j++)
            {
                lock (locker)
                {
                    sum += (int)text[i + k * j];
                }
            }
        }

        private void InputTextTB_TextChanged(object sender, EventArgs e)
        {
            if (InputTextTB.Text.Equals(string.Empty))
                ExecuteBtn.Enabled = false;
            else
                ExecuteBtn.Enabled = true;

            CheckSumTB.Text = string.Empty;
            CharCodesTB.Text = string.Empty;
        }
    }
}
