using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreiMassive8
{
    class Program
    {
        static void Main()
        {
            const int N = 8;                 
            int[,] mas = new int[N, N];          
            int[] masi = new int[N];
            int[] masj = new int[N];
            int count = 0, ind = 0;

            Random r = new Random();

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    mas[i, j] = r.Next(-20, 20);   // диапазон для проверки
                                                 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(mas[i, j] + " ");
                Console.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    masi[j] = mas[i, j];

                for (int m = 0; m < N; m++)
                {
                    for (int n = 0; n < N; n++)
                    {
                        if (masi[n] == mas[n, m])
                        {
                            count++;
                            ind = m;
                        }
                        else
                        {
                            count = 0;
                            break;
                        }
                    }

                    if (count == N && i == ind)
                        Console.WriteLine("\nk: " + (i + 1));
                }
            }

            int amount = 0;
            bool check = false;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    amount += mas[i, j];
                    if (mas[i, j] < 0) check = true;
                }
                if (check)
                {
                    Console.WriteLine("Сумма элементов (строка " + i + "): " + amount);
                    check = false;
                }
                amount = 0;
            }

            Console.ReadKey();
        }
    }
}
