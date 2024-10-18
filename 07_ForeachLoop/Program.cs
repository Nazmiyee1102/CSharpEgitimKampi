using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            #region Örnek 1
            //string[] cities = { "milano", "roma", "budapeşte", "istanbul", "ankara", "varşova" };

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            #endregion

            #region Örnek 2

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Örnek 3

            //int[] numbers = { 85, 46, 78, 93, 667, 95, 273, 427, 143, 190902009, 850, 69, 23, 530 };

            //foreach (var item in numbers)
            //{
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            #endregion

            #region Örnek 4

            //int[] numbers = { 78, 65, 43, 32, 21, 10, 98, 3 };

            //int total = 0;

            //foreach (var item in numbers)
            //{
            //    total += item;
            //}

            //Console.WriteLine(total);

            #endregion

            #region Örnek 5

            //List<int> numbers = new List<int>()
            //{
            //    1,2,6,54,548,512,46578
            //};

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);

            //}

            #endregion

            #region Örnek 6

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion



            #endregion


            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** Örnek Sınav Sistemi Uygulaması *****");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------");

            //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.Write("Sınıfınızda kaç öğrenci var? ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");

            //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];

            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için üç sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notlar toplanacak
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }

            //sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAvg[i]}");

                //öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
                }

                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");

                }
                Console.WriteLine();
            }



            #endregion

            Console.Read();
        }
    }
}
