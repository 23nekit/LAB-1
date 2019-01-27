using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Лабораторнаробота1
{
    class Program
    {
        static int[] ArraySort(int[] array)
        {
            int t;
            for(int i = 1; i < array.Length; i++)
            {
                for(int j = array.Length - 1; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        t = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = t;
                    }
                }
            }
            return array;
        }
        static int[] ArrayRandom(int n)
        {
            Console.Write("Дiапазон рандому вiд :");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.Write("Дiапазон рандому до :");
            int to = Convert.ToInt32(Console.ReadLine());
            int[] arrayrandom = new int[n];
            Random RndGen = new Random();
            for (int i = 0; i < arrayrandom.Length; i++)
            {
                arrayrandom[i] = RndGen.Next(from, to + 1);
            }
            return arrayrandom;
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть елементiв масиву :");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = ArrayRandom(N);
            int sum = 0;
            Console.WriteLine("Ваш масив :" + string.Join(" ", array));
            array = ArraySort(array);
            Console.WriteLine("Сортирований масив :" + string.Join(" ", array));
            for(int i=0;i< N; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine("Сума непарних елементiв :{0}",sum);
            Console.ReadKey();
        }
    }
}
