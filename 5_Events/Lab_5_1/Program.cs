using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_5_1
{
    class LinkedList
    {       
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data, Node next)
            {
                this.data = data;
                this.next = next;
            }
        }

        public int count = 0;
        public Node head = null;
        public Node tail = null;

        // Добавить элемент в конец списка
        public void AddBack(int data)
        {
            if (head == null)
            {
                head = new Node(data, null);
                tail = head;
            }
            else
            {
                tail.next = new Node(data, null);
                tail = tail.next;
            }

            ++count;
        }

        // добавить элемен в начало спсика
        public void AddFront(int data)
        {
            if (head == null)
            {
                head = new Node(data, null);
                tail = head;
            }

            else
            {
                Node new_node = new Node(data, head);
                head = new_node;
            }

            ++count;
        }

        // Вставка элемента
        public void Insert(int index, int data)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException();

            if (index == 0)
            {
                AddFront(data);
            }

            else
            {
                Node r = head;

                for (int i = 1; i < index; ++i)
                    r = r.next;

                Node new_node = new Node(data, r.next);
                r.next = new_node;

                ++count;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (Node r = head; r != null; r = r.next)
                yield return r.data;
        }

        // Получение индекса элемента списка
        public int Get_Index(int x)
        {
            int length = -1;
            Node cur;
            if (head != null)
            {
                cur = head;
                while (cur.next != null && cur.data != x)
                {
                    cur = cur.next;
                    length++;
                }
            }
            return length + 1;
        }

        // Получение длины списка
        public int Len()
        {
            int length = 0;
            Node cur;
            if (head != null)
            {
                cur = head;
                while (cur.next != null)
                {
                    cur = cur.next;
                    length++;
                }
            }
            return length + 1;
        }
        
        // Получение значения списка по индексу
        public int Get_value(int i)
        {
            int value = 0, count = -1;
            Node cur;
            if (head != null)
            {
                cur = head;
                while (count != i)
                {
                    count++;
                    value = cur.data;
                    try
                    {
                        cur = cur.next;
                    }
                    catch
                    {
                        break;
                    }
                }
            }
            return value;
        }

        // Установка значения элемента в спсике по индексу
        public void Set_Value(int i, int x)
        {
            int count = 0;
            Node cur;
            if (head != null)
            {
                cur = head;
                while (cur.next != null && count != i)
                {
                    cur = cur.next;
                    count++;
                }
                cur.data = x;
            }
        }

        // Обмен местами двух элементов списка
        public void Swap(int i1, int i2)
        {
            int val1 = Get_value(i1);
            int val2 = Get_value(i2);
            Set_Value(i2, val1);
            Set_Value(i1, val2);
        }

        // Сортировка части списка
        public void Merge_List(int start, int mid, int end)
        {
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int l = start; l < mid; l++)
                left.Add(Get_value(l));

            for (int r = mid; r < end; r++)
                right.Add(Get_value(r));

            int k = start;
            int i = 0;
            int j = 0;

            while (start + i < mid && mid + j < end)
            {
                if (left[i] <= right[j])
                {
                    Set_Value(k, left[i]);
                    i++;
                }
                else
                {
                    Set_Value(k, right[j]);
                    j++;
                }
                k++;
            }
            if (start + i < mid)
                while (k < end)
                {
                    Set_Value(k, left[i]);
                    i++;
                    k++;
                }
            else
            {
                while (k < end)
                {
                    Set_Value(k, right[j]);
                    j++;
                    k++;
                }
            }
        }

        // Сортировка
        public void Merge_Sort(int start, int end)
        {
            if (end - start > 1)
            {
                int mid = (start + end) / 2;
                Thread k1 = new Thread(() => Merge_Sort(start, mid));
                Thread k2 = new Thread(() => Merge_Sort(mid, end));
                k1.Start();
                k2.Start();
                k1.Join();
                k2.Join();

                Merge_List(start, mid, end);
            }
        }
    }
    class Program
    {       
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.Write("Введите количество элементов списка: ");
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                list.AddBack(rand.Next(0, 30));
            }

            foreach (int item in list)
                Console.Write("{0} ", item);
            Console.WriteLine();

            list.Merge_Sort(0, n);

            foreach (int item in list)
                Console.Write("{0} ", item);
            Console.WriteLine();
        }
    }
}
