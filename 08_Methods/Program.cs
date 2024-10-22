using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            #region Örnek 1
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            #endregion

            //CustomerList();
            //Sum();

            #region Örnek 2

            //void Sum()
            //{
            //    int x = 1; 
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            #endregion

            #endregion

            #region Geri Dönüşü Olmayan String Parametreli Metotlar

            #region Örnek 1

            void WriteMethod(string customerName)
            {
                Console.WriteLine(customerName);
            }

            //WriteMethod("Ayşe Yıldız");

            #endregion

            #region Örnek 2

            void CustomerCard(string firstName, string lastName)
            {
                Console.WriteLine($"Müşteri Adı : {firstName} - Soyadı : {lastName}");
            }

            //CustomerCard("Nazmiye", "Kurban");

            #endregion

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum2(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum2(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return $"{ name} { surname}";
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = $"Ülke : {countryName} - Başkent : {capital} - Bayrak Rengi : {flagColor}";
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz : ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz : ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini/Renklerini Giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Ukrayna", "Kiev", "Sarı-Mavi"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum3(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum3(77,99));
            //Console.WriteLine(Sum3(36,25));
            //Console.WriteLine(Sum3(44,36));
            //Console.WriteLine(Sum3(45,98));
            //Console.WriteLine(Sum3(14,20));

            #endregion

            #region Örnek

            //string ExamResult(string student,int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return $"{student} adlı öğrenci sınavı geçti. Ortalama : {result}";
            //    }
            //    else
            //    {
            //        return $"{student} adlı öğrenci sınavda başarısız oldu. Ortalama : {result}"; ;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            //Console.WriteLine(ExamResult("Buse", 0, 88, 33));



            #endregion

           


            Console.Read();
        }
    }
}
