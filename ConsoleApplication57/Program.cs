using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        public static bool NextSet(int[] a, int n, int m)
        {
            int j = m - 1;
            while (j >= 0 && a[j] == n) j--;
            if (j < 0) return false;
            if (a[j] >= n)
                j--;
            a[j]++;
            if (j == m - 1) return true;
            for (int k = j + 1; k < m; k++)
                a[k] = 1;
            return true;
        }
        public static void Print(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
        static void Try(out int inputnumber)//проверка правильности ввода числа
        {
            inputnumber = 0;
            bool flag = true;
            while (flag == true)
            {
                try
                {

                    string x = Console.ReadLine();
                    inputnumber = int.Parse(x);
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Неверное значение! Введите целое число");
                    flag = true;
                }
            }
        }
        public static void Main(string[] args)
        {
            string answer = "yes";


            while (answer == "yes")
            {

                int n, m;
                Console.WriteLine("Введите N");
                Console.Write("N=");

                bool f1 = true;
                Try(out n);

                while (f1 && n < 0)
                {
                    Console.WriteLine("Неверное значение! Введите положительное число");
                    Try(out n);
                    if (n >= 0)
                    {
                        f1 = false;
                    }
                }

                Console.WriteLine("Введите K");
                Console.Write("K=");

                f1 = true;
                Try(out m);

                while (f1 && m < 0)
                {
                    Console.WriteLine("Неверное значение! Введите положительное число");
                    Try(out m);
                    if (m >= 0)
                    {
                        f1 = false;
                    }
                }

                int[] a;
                if (n > m)
                {
                    a = new int[n - 1];
                    for (int i = 0; i < n - 1; i++)
                    {
                        a[i] = 1;
                    }
                    Print(a, n - 1);
                    Console.WriteLine();
                    while (NextSet(a, n, m))
                    {
                        Print(a, n - 1);
                        Console.WriteLine();
                    }
                }
                else
                {
                    a = new int[m];
                    for (int i = 0; i < m; i++)
                    {
                        a[i] = 1;
                    }
                    Print(a, m);
                    Console.WriteLine();
                    while (NextSet(a, n, m))
                    {
                        Print(a, m);
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Продолжить? yes/no");
                answer = Console.ReadLine();

            }

        }
    }
}


