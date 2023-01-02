using System;
using System.Threading;

namespace Lab_5_2
{
    class Program
    {
        static int x = 1;
        static Thread one, two;

        // Подсчет факториала
        public static double Fuct(int n)
        {
            double g = 1;

            for (int i = 1; n >= i; ++i)
            {
                g = g * i;
            }

            return g;
        }         

        // Возведение в степень
        public static long IntPow(int pow)
        {
            return (pow == 0) ? x :
            ((pow & 0x1) == 0 ? x : 1) *
                IntPow(pow >> 1);
        }

        // Ряд Маклорена
        public static double McLine(int n)
        {
            double sum = 0;
            double k = 0, k1 = 0;

            for (int i = 0; i < n; i++)
            {
                int y = i;
                one = new Thread(() => k = IntPow(y));
                two = new Thread(() => k1 = Fuct(y));

                one.Start();
                two.Start();

                one.Join();
                two.Join();

                sum += k / k1;
                Console.WriteLine("Сумма: " + sum);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов ряда: ");
            int num = int.Parse(Console.ReadLine());
            McLine(num);
        }
    }
}
