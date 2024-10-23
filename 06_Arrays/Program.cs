using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            #region Örnek 1
            //string[] colors = { "Lacivert", "Sarı", "Mavi", "Yeşil"};

            //Console.WriteLine(colors[2]);
            #endregion

            #region Örnek 2

            //string[] cities = { "Bayburt", "İstanbul", "Ankara", "İzmir", "Bursa" };

            //Console.WriteLine(cities[0]);
            #endregion

            #region Örnek 3

            //int[] numbers = { 66, 69, 72 };

            //Console.WriteLine(numbers[2]);

            #endregion

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            #region Örnek 1
            //string[] colors = { "Red", "Green", "Blue", "Yellow", "Dark Blue" };

            //foreach (var item in colors)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Örnek 2

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (var i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}



            #endregion

            #region Örnek 3

            //char[] symbols = { 'a', 'b', 'c', 'd', };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]); 
            //}

            #endregion

            #region Örnek 4

            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //int maxNumber = sayilar[0];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > maxNumber)
            //    {
            //        maxNumber = sayilar[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            #endregion

            #region  Örnek 5

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);


            #endregion

            #region Örnek 6

            //int[] numbers = { 45, 15, 84, 65, 98, 71 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]); 
            //}

            //int[] numbers = { 45, 15, 84, 65, 98, 71 };

            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]); 
            //}

            #endregion

            #endregion

            #region Dizi Metotları

            #region IndexOf
            //string[] customers = { "ali", "ayşe", "buse", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);
            #endregion

            #region Max - Min

            //int[] numbers = { 45, 85, 96, 63, 86, 74, 10, 25, 22, 36 };

            //Console.WriteLine($"Dizinin en büyük elemanı : {numbers.Max()} - Dizinin en küçük elemanı : {numbers.Min()}");

            #endregion

            #region Klavyeden Veri Alma

            #region Örnek 1

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"{i +1 } - {cities[i]}");
            //}
            #endregion

            #region Örnek 2

            //int[] numbers = { 69, 25, 32, 34, 36, 45 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            #endregion


            #region Örnek 3

            int[] numbers = { 84, 5, 11, 26, 65, 49 };

            Console.WriteLine("Çift sayılar : ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Tek sayılar : ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }



            #endregion


            #endregion

            #endregion

            Console.Read();
        }
    }
}
