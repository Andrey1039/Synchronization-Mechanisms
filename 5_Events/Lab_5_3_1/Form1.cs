using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lab_5_4_1
{
    public partial class Execution : Form
    {
        List<EventWaitHandle> events;
        List<Thread> hThread;
        
        public Execution()
        {
            InitializeComponent();

            events = new List<EventWaitHandle>(8);
            CreateEvents();

            hThread = new List<Thread>(2);

            hThread.Add(new Thread(WaitClose));
            hThread[0].Start();

            hThread.Add(new Thread(Go));
            hThread[1].Start();
        }

        // Создание и установка событий
        private void CreateEvents()
        {
            try
            {
                for (int i = 0; i < 8; i++)
                    events.Add(EventWaitHandle.OpenExisting($"Event{i}"));
            }
            catch
            {
                for (int i = 0; i < 8; i++)
                    events.Add(new EventWaitHandle(false, EventResetMode.AutoReset, $"Event{i}"));
            }
        }

        // Обработка события на закрытие второй программы
        private void WaitClose()
        {
            while (true)
            {
                events[6].WaitOne();
                MessageBox.Show("Программа 1 закрыта!");
            }
        }
        
        // Действие 1
        private void Action1()
        {
            BigInteger temp;

            if (BigInteger.TryParse(Number2TB.Text, out temp) && BigInteger.TryParse(NumberTB.Text, out temp))
            {
                var myBigInteger = BigInteger.Parse(NumberTB.Text);
                var myBigInteger1 = BigInteger.Parse(Number2TB.Text);

                myBigInteger *= myBigInteger1;
                NumResultTB.Text = myBigInteger.ToString();
            }
            else 
                MessageBox.Show("Вы не ввели числа!");
        }

        // Действие 2
        public void Action2()
        {
            string[] data;
            List<float> mass = new List<float>();

            try
            {
                using (StreamReader reader = new StreamReader("sob2.txt"))
                {
                    data = reader.ReadToEnd().Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            foreach (string value in data)
                mass.Add(float.Parse(value));

            for (int i = 0; i < mass.Count; i++)
                ArrayResultTB.Text += $"{mass[i]} ";
            ArrayResultTB.Text += "\n";

            mass = mass.Distinct().ToList();

            try
            {
                using (StreamWriter writer = new StreamWriter("sob2_exit.txt"))
                {
                    writer.Write(mass);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            for (int i = 0; i < mass.Count; i++)
                ArrayResultTB.Text += $"{mass[i]} ";
            ArrayResultTB.Text += "\n";
        }

        // Действие 3
        public void Action3()
        {
            string data;

            try
            {
                using (StreamReader reader = new StreamReader("sob3.txt"))
                {
                    data = reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            TextResultTB.Text = data;
            string stringInput = new string(data.Where(c => !char.IsPunctuation(c)).ToArray());

            List<string> lstString = new List<string>();
            string curString = "";
            foreach (var vari in stringInput)
            {
                curString += vari;
                if (vari == ' ')
                {
                    lstString.Add(curString.Trim());
                    curString = "";
                }
            }
            lstString.Add(curString.Trim());

            var result = lstString.GroupBy(x => x)
                .OrderByDescending(g => g.Count())
                .ThenBy(g => g.Key, StringComparer.Ordinal)
                .First().Key;

            FreqWordTB.Text = result;

            var countInputs = lstString.FindAll(x => x == result);
            int countInput = countInputs.Count;
            AmountTB.Text = countInput.ToString();
        }

        // Действие 4
        public void Action4()
        {
            int temp;
            if (int.TryParse(DimensionTB.Text, out temp))
            {
                int COUNT = int.Parse(DimensionTB.Text);
                int[,] arr = new int[COUNT, COUNT];
                int min = int.MaxValue, max = int.MinValue;
                Random random = new Random();

                for (int row = 0; row < COUNT; row++)
                    for (int col = 0; col < COUNT; col++)
                        arr[row, col] = random.Next(-50, 51);

                MatrixTB.Text = string.Empty;
                for (int row = 0; row < COUNT; row++)
                {
                    for (int col = 0; col < COUNT; col++)
                        MatrixTB.Text += arr[row, col].ToString() + "\t";
                    MatrixTB.Text += "\n";
                }

                // Нахождение max элемента ниже ПОБОЧНОЙ диагонали
                for (int row = 0; row < COUNT; row++)
                    for (int col = 0; col < COUNT - row; col++)
                        if (arr[row, col] > max)
                            max = arr[row, col];

                // Нахождение min выше ГЛАВНОЙ диагонали
                for (int row = 0; row < COUNT; row++)
                    for (int col = 0; col < row; col++)
                        if (arr[row, col] < min)
                            min = arr[row, col];

                MaxTB.Text = max.ToString();
                MinTB.Text = min.ToString();
            }
            else
                MessageBox.Show("Вы не ввели размерность!");
        }

        // Действие 5
        public void Action5()
        {
            int temp;

            if (int.TryParse(AmountNTB.Text, out temp))
            {
                int n = int.Parse(AmountNTB.Text);
                int len = n + 1;
                int[] primes = new int[len];
                NumbersTB.Text = string.Empty;

                for (int i = 0; i < len; i++)
                    primes[i] = i;

                for (int i = 2; i < len; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if (primes[j] == 0)
                            continue;

                        if (j % i == 0)
                        {
                            primes[j] = 0;
                            continue;
                        }
                    }
                }
                for (int i = 0; i < len; i++)
                    if (primes[i] != 0 && primes[i] != 1)
                        NumbersTB.Text += $"{primes[i]} ";
            }
            else MessageBox.Show("Вы не ввели значение n!");
        }

        // Запуск действий по событию
        public void Go()
        {
            while (true)
            {
                events[0].WaitOne();

                if (events[1].WaitOne(1, true))
                {
                    Thread hThread1 = new Thread(Action1);
                    hThread1.Start();
                }
                if (events[2].WaitOne(1, true))
                {
                    Thread hThread2 = new Thread(Action2);
                    hThread2.Start();
                }
                if (events[3].WaitOne(1, true))
                {
                    Thread hThread3 = new Thread(Action3);
                    hThread3.Start();
                }
                if (events[4].WaitOne(1, true))
                {
                    Thread hThread4 = new Thread(Action4);
                    hThread4.Start();
                }
                if (events[5].WaitOne(1, true))
                {
                    Thread hThread5 = new Thread(Action5);
                    hThread5.Start();
                }

                events[0].Reset();
            }
        }

        private void NumberTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == '-')
            {
                return;
            }
            else e.Handled = true;
        }

        private void DimensionTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                return;
            }
            else e.Handled = true;
        }

        // Обработка закрытия текущей программы
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            events[7].Set();

            for (int i = 0; i < 2; i++)
                hThread[i].Abort();

            Application.Exit();
        }
    }
}
