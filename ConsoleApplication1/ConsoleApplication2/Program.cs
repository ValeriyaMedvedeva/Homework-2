using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static int Minimum(int[,] array)
        {
            int k = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < k) k = array[i, j];
                }
            return k;
        }
        public static int Maxmum(int[,] array)
        {
            int k = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > k) k = array[i, j];
                }
            return k;
        }
        public static void Replace(int[,] array)
        {
            int a = Minimum(array);
            int b = Maxmum(array);
            int k = 0, m = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == a) { k = i; m = j; break; }
                }
            array[k, m] = b;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == b && (i != k || j != m)) array[i, j] = a;
                }
        }
        public static void Replace2(int[,] array)
        {
            int min = Minimum(array);
            int max = Maxmum(array);
            int b;
            int a = b = array[0, 0];
            int m = 0, n = 0, l = 0, s = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < a && array[i, j] > min) { a = array[i, j]; n = i; m = j; }
                }
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > b && array[i, j] < max) { b = array[i, j]; l = i; s = j; }
                }
            array[n, m] = b;
            array[l, s] = a;
        }
        public static void Printf(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            int[,] massiv = new int[3, 3];
            string c;
            int min, max;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    c = Convert.ToString(Console.ReadLine());
                    if (!Int32.TryParse(c, out massiv[i, j])) { Console.WriteLine("Введено не число,пожалуйста,повторите ввод"); j--; }
                    else massiv[i, j] = Convert.ToInt32(c);
                }
            Console.Clear();
            Console.WriteLine("Получился массив:");
            Printf(massiv);
            min = Minimum(massiv);
            Console.WriteLine("Минимальное число в массиве:");
            Console.WriteLine(min);
            max = Maxmum(massiv);
            Console.WriteLine("Максимальное число в массиве:");
            Console.WriteLine(max);
            Replace(massiv);
            Console.WriteLine("Результат замены min на max,max на min:");
            Printf(massiv);
            Replace2(massiv);
            Console.WriteLine("Результат замены второго min на второй max,второго max на второй min:");
            Printf(massiv);
        }
    }
}
