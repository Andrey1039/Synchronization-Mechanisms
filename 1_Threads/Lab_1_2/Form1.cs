using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lab_1_4
{
    public partial class MainWindow : Form
    {
        List<Thread> hThread;
        Random r;
        bool _continue;

        public MainWindow()
        {
            InitializeComponent();

            ComboboxAdd(Thread1Box);
            ComboboxAdd(Thread2Box);
            ComboboxAdd(Thread3Box);

            _continue = false;
            hThread = new List<Thread>(3);
        }

        // Добавляем названия приоритетов
        private void ComboboxAdd(ComboBox comboBox)
        {
            comboBox.Items.Add("Наивысший");
            comboBox.Items.Add("Выше нормы");
            comboBox.Items.Add("Нормальный");
            comboBox.Items.Add("Ниже нормы");
            comboBox.Items.Add("Самый низкий");
            comboBox.SelectedIndex = 2;
        }

        // Рисование кругов
        public void DrawCircle(Color color)
        {
            for (int i = 0; _continue; i++)
            {
                int x = r.Next(0, Width);
                int y = r.Next(0, Height);
                this.CreateGraphics().DrawEllipse(new Pen(color, 3), x, y, 20, 20);
                Thread.Sleep(100);
            }

            for (int i = 0; i < hThread.Count; i++)
                hThread[i].Join();
        }

        // Установка приоритета
        private void Priority(ComboBox comboBox, Thread hThread)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0: hThread.Priority = ThreadPriority.Highest; break;
                case 1: hThread.Priority = ThreadPriority.AboveNormal; break;
                case 2: hThread.Priority = ThreadPriority.Normal; break;
                case 3: hThread.Priority = ThreadPriority.BelowNormal; break;
                case 4: hThread.Priority = ThreadPriority.Lowest; break;
            }
        }

        // Выбор приоритета
        private void SetPriority()
        {
            Priority(Thread1Box, hThread[0]);
            Priority(Thread2Box, hThread[1]);
            Priority(Thread3Box, hThread[2]);
        }

        private void ThreadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hThread != null)
                SetPriority();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (hThread != null)
                for (int i = 0; i < hThread.Count; i++)
                    hThread[i].Abort();

            hThread.Clear();
            hThread.Add(new Thread(() => DrawCircle(Color.Green)));
            hThread.Add(new Thread(() => DrawCircle(Color.Red)));
            hThread.Add(new Thread(() => DrawCircle(Color.Blue)));

            SetPriority();
            r = new Random();
            _continue = true;

            for (int i = 0; i < hThread.Count; i++)
                hThread[i].Start();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hThread.Count; i++)
                hThread[i].Abort();

            _continue = false;
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
