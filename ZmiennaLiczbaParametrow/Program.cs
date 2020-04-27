using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZmiennaLiczbaParametrow
{
    class Program
    {
        static void Sort(int[] tablicaOrg)
        {
            var tablica = tablicaOrg.ToArray();
            int n = tablica.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int tmp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
        }

        static void SortParams(params int[] tablica)
        {
            int n = tablica.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int tmp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tmp;
                    }
                }
                n--;
            }
            while (n > 1);
        }

        public static int AddP(params int[] arg)
        {
            int r = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                r += arg[i];
            }
            return r;
        }

        public static int AddPLambda(params int[] arg)
        {
            return arg.Sum();
        }

        public static int Add(int a, int b, int c, int d, int e, int f, int g, int h, int i, int j, int k, int l, int m, int n, int o)
        {
            return a + b + c + d + e + f + g + h + i + j + k + l + m + n + o;
        }

        static void Main(string[] args)
        {

            int[] arr = { 1000, 33, 123, 10, 1, 12442, 99, 111, 1000, 33, 123, 10, 1, 12442, 99, 111, 1000, 33, 123, 10, 1, 12442, 99, 111, 33, 123, 10, 1, 12442, 99, 111, 
                1000, 33, 123, 10, 1, 12442, 99, 111, 1000, 33, 123, 10, 1, 12442, 99, 111, 33, 123, 10, 1, 12442, 99, 111, 1000, 33, 123, 10, 1, 12442, 99, 111, 1000, 33, 
                };

            Console.WriteLine("przekazywaniem parametrów nieustalonych (zmiennej liczby parametrów) – porównanie czasów działania z przekazywaniem stałej liczby parametrów\n\nTest dodawania liczb...\n");

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 500000; i++)
            {
                AddP(24, 23, 23, 42234, 24, 25, 26, 28, 12, 34, 231, 4, 5786, 789, 7);

            }
            watch.Stop();
            Console.WriteLine("Dodawanie liczb params: " + watch.ElapsedMilliseconds + " ms");

            watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 500000; i++)
            {
                AddPLambda(24, 23, 23, 42234, 24, 25, 26, 28, 12, 34, 231, 4, 5786, 789, 7);

            }
            watch.Stop();
            Console.WriteLine("Dodawanie liczb params lambda: " + watch.ElapsedMilliseconds + " ms");

            watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 500000; i++)
            {
                Add(24, 23, 23, 42234, 24, 25, 26, 28, 12, 34, 231, 4, 5786, 789, 7);

            }
            watch.Stop();
            Console.WriteLine("Dodawanie liczb: " + watch.ElapsedMilliseconds + " ms\n");

            Console.WriteLine("===================================================================================================================\n\nTest sortowania bąbelkowego...\n");

            watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 20000; i++)
            {
                Sort(arr);
            }
            watch.Stop();
            Console.WriteLine("Sortowanie babelkowe: " + watch.ElapsedMilliseconds + "ms");

            watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 20000; i++)
            {
                SortParams(1000, 33, 123, 10, 1, 12442, 99, 111, 1000, 33, 123, 10, 1, 12442, 99, 111, 1000, 33, 123, 10, 1, 12442, 99, 111, 33, 123, 10, 1, 12442, 99, 111,
                1000, 33, 123, 10, 1, 12442, 99, 111, 1000, 33, 123, 10, 1, 12442, 99, 111, 33, 123, 10, 1, 12442, 99, 111, 1000, 33, 123, 10, 1, 12442, 99, 111, 1000, 33);
            }
            watch.Stop();
            Console.WriteLine("Sortowanie babelkowe params: " + watch.ElapsedMilliseconds + "ms\n\n");



            Console.WriteLine("Kliknij dowolny klawisz aby zakończyć");
            Console.ReadKey();
        }
    }
}
