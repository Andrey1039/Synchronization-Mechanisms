using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lab_5_4_2
{
    public partial class Actions : Form
    {
        private List<EventWaitHandle> events;
        private Thread hThread;

        public Actions()
        {
            InitializeComponent();

            events = new List<EventWaitHandle>(8);
            CreateEvents();
            
            hThread = new Thread(WaitClose);
            hThread.Start();
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
                events[7].WaitOne();
                MessageBox.Show("Программа 2 закрыта!");
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (Action1.Checked)
                events[1].Set();
            if (Action2.Checked)
                events[2].Set();
            if (Action3.Checked)
                events[3].Set();
            if (Action4.Checked)
                events[4].Set();
            if (Action5.Checked)
                events[5].Set();

            events[0].Set();           
        }

        // Обработка закрытия текущей программы
        private void Actions_FormClosed(object sender, FormClosedEventArgs e)
        {
            events[6].Set();
            hThread.Abort();
            Application.Exit();
        }
    }
}
