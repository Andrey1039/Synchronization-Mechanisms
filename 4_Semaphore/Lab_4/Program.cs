using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace Lab_4
{
    class Program
    {
        static Queue<char> pool = new Queue<char>();
        static Semaphore semFull;
        static Semaphore semEmpty;
        static Mutex mut1 = new Mutex();
        static Random rnd = new Random();
        static Random rnd1 = new Random();

        // Генерация случайной строки
        private static string GenText()
        {
            int k = rnd1.Next(1, 50);
            int[] arr = new int[k];
            string Password = "";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(33, 125);
                Password += (char)arr[i];
            }

            return Password;
        }

        // Заполнение файлов случайными строками
        private static void CreateFiles(int m)
        {
            for (int i = 0; i < m; i++)
            {
                string pass = GenText();
                string name = $"in{i}.txt";

                using (StreamWriter writer = new StreamWriter(name))
                    writer.Write(pass);
            }
        }

        // Вывод в файл
        public static void Output(StreamWriter writer, int n)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    semFull.WaitOne();
                    mut1.WaitOne();

                    if (pool.Count != 0) writer.Write(pool.Dequeue());

                    mut1.ReleaseMutex();
                    semEmpty.Release(1);
                }
            }
        }

        // Чтение из файла
        public static void Input(StreamReader reader, int n)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    semEmpty.WaitOne();
                    mut1.WaitOne();

                    if (!reader.EndOfStream) pool.Enqueue(Convert.ToChar(reader.Read()));

                    mut1.ReleaseMutex();
                    semFull.Release(1);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите длину пула: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите кол-во потоков для печати: ");
            int m = int.Parse(Console.ReadLine());

            CreateFiles(m);

            semFull = new Semaphore(0, n);
            semEmpty = new Semaphore(n, n);

            try
            {
                using (StreamWriter writer = new StreamWriter("out.txt"))
                {
                    Thread print = new Thread(() => Output(writer, n));
                    List<Thread> read = new List<Thread>();

                    for (int i = 0; i < m; i++)
                    {
                        int y = i;
                        string name = $"in{y}.txt";

                        using (StreamReader reader = new StreamReader(name))
                        {
                            read.Add(new Thread(() => Input(reader, n)));
                            read[y].Start();

                            print = new Thread(() => Output(writer, n));
                            print.Start();

                            read[y].Join();
                            print.Join();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
