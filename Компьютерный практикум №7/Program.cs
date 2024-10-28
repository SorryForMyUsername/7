using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Компьютерный_практикум__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Вывести в столбик 10 раз слово "Привет".
            //Цикл с предусловием
            //int count = 1;
            //while (count <= 10)
            //{
            //    Console.WriteLine("Привет");
            //    count++;
            //}
            //Цикл с постуловием
            //int count = 1;
            //do
            //{
            //    Console.WriteLine("Привет");
            //    count++;
            //}
            //while (count <= 10);
            //Цикл с параметром
            //for (int count = 1; count <= 10; count++)
            //{
            //    Console.WriteLine("Привет");
            //}

            //Задача 2. Вывести в столбик первые 10 натуральных чисел.
            //Цикл с предусловием
            //int n = 1;
            //while (n <= 10)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}
            //Цикл с постусловием
            //int n = 1;
            //do
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}
            //while (n <= 10);
            //Цикл с параметром
            //for(int n = 1; n <= 10; n++)
            //{
            //    Console.WriteLine(n);
            //}

            //Задача 3. вывести в столбик первые 5 натуральных чисел в обратном порядке.
            //Цикл с предусловием
            //int n = 5;
            //while (n > 0)
            //{
            //    Console.WriteLine(n);
            //    n--;
            //}
            //Цикл с постусловием
            //int n = 5;
            //do    
            //{
            //    Console.WriteLine(n);
            //    n--;
            //}
            //while (n > 0);
            //Цикл с параметром
            //for(int n = 5; n > 0; n--)
            //{
            //    Console.WriteLine(n);
            //}

            //Задача 4. вывести на экран целые числа из интервала от 1 до n.
            //Цикл с предусловием
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //int count = 1;
            //while (count <= n)
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}
            //Цикл с постусловием
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //int count = 1;
            //do
            //{
            //    Console.WriteLine(count);
            //    count++;
            //}
            //while (count <= n);
            //Цикл с параметром
            //Console.Write("n = ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int count = 1; count <= n; count++)
            //{
            //    Console.WriteLine(count);
            //}

            //Задача 5. запросить у пользователя 5 слов,
            //после чего вывести вначале дважды каждое нечетное слово
            //и затем трижды каждое четное слово,
            //между выводимыми словами вставить разделитель
            //в виде трех символьных пробелов (“   ”).
            //int[] words = new int[5];
            //for(int i = 0; i < words.Length; i++)
            //{
            //    Console.Write($"{i + 1}-ое слово: ");
            //    words[i] = int.Parse(Console.ReadLine());
            //}
            //for(int i = 0; i < words.Length; i++)
            //{
            //    if (words[i] % 2 != 0)
            //    {
            //        Console.Write($"{words[i]}   {words[i]}   ");
            //    }
            //}
            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i] % 2 == 0)
            //    {
            //        Console.Write($"{words[i]}   {words[i]}   {words[i]}   ");
            //    }
            //}

            Console.ReadKey();
        }
    }
}
