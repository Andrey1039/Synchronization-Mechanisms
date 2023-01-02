using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество потоков: ");
            int threadsNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк и основание хеш-функции: ");
            int rowsNumber = int.Parse(Console.ReadLine());

            CMonitor hTable = new CMonitor(threadsNumber, rowsNumber);
            hTable.Gen();
            hTable.Show();
        }
    }
    class CMonitor
    {
        int rowsNumber;
        int threadsNumber;
        HashTable[] table;
        Random rand;
        int[] occupated_rows;
        int[] free_rows;
        Mutex[] mutexObj;

        // Структура хеш-таблицы
        struct HashTable    
        {
            public List<int> inf;
        };

        // Модель монитора
        public CMonitor(int n, int k)   
        {
            this.rowsNumber = k;
            this.threadsNumber = n;
            this.occupated_rows = new int[k];
            this.free_rows = new int[k];
            this.table = new HashTable[k];
            this.rand = new Random();
            this.mutexObj = new Mutex[k];

            for (int i = 0; i < k; i++)
                mutexObj[i] = new Mutex();

            for (int i = 0; i < k; i++)
            {
                table[i].inf = new List<int>();
            }
        }

        // Занятые строки
        public void OcupateRow(int row_number)  
        {
            occupated_rows[row_number] = 1;
            free_rows[row_number] = 0;
        }

        // Свободные строки
        public void FreeRow(int row_number) 
        {
            occupated_rows[row_number] = 0;
            free_rows[row_number] = 1;
        }

        // Создание чисел и отправка на заполнение в таблицу
        public void Gen()   
        {
            Thread[] hThread = new Thread[threadsNumber];
            Thread[] hThread2 = new Thread[threadsNumber];
            for (int i = 0; i < threadsNumber; i++)
            {
                int temp = i;
                int num = 0;

                hThread[temp] = new Thread(y => num = Gen_E(temp));
                hThread[temp].Start();

                hThread2[temp] = new Thread(y => Fill(num));
                hThread2[temp].Start();
            }
        }

        // Генерация чисел
        private int Gen_E(int p)    
        {
            int num = rand.Next(1000);
            return num;
        }

        // Вычисление хеш-кода
        private int Hash(int x) 
        {
            return Math.Abs(x) % rowsNumber;
        }

        // Заполнение таблицы
        private void Fill(int x)
        {
            int cod = Hash(x);

            mutexObj[cod].WaitOne();

            OcupateRow(cod); 
            table[cod].inf.Add(x);
            FreeRow(cod);

            mutexObj[cod].ReleaseMutex();
        }

        // Вывод таблицы на экран
        public void Show()  
        {
            for (int i = 0; i < rowsNumber; i++)
            {
                Console.WriteLine($"Хеш-код {i}, размер списка {table[i].inf.Count()}:\n");
                if (table[i].inf.Count() == 0) Console.Write("\tПусто\n");

                foreach (int p in table[i].inf)
                {
                    Console.Write($"\t{p}\n");
                }

                Console.WriteLine();
            }
        }
    }
}
