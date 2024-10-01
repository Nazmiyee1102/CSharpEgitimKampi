using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            //YazdirmaKomutlari();
            //StringDegiskenler();
            //IntDegiskenler();

            Console.Read();
        }

        #region Int Değişkenler 

        private static void IntDegiskenler()
        {
            //int değişkenler

            //int number = 0;
            //Console.WriteLine($"Sayı: {number}");

            int hamburgerPrice = 250, cokePrice = 35, waterPrice = 10, friesPrice = 50, pizzaPrice = 300, lemonadePrice = 30;

            Console.WriteLine(new string('*', 5) + " " + "Restoran Menü Fiyatı" + " " + new string('*', 5));
            Console.WriteLine();
            Console.WriteLine($"-----Kola: {cokePrice}" + " TL");
            Console.WriteLine($"-----Hamburger: {hamburgerPrice}" + " TL");
            Console.WriteLine($"-----Pizza: {pizzaPrice}" + " TL");
            Console.WriteLine($"-----Limonata: {lemonadePrice}" + " TL");
            Console.WriteLine($"-----Kızartma: {friesPrice}" + " TL");
            Console.WriteLine($"-----Su: {waterPrice}" + " TL");
            Console.WriteLine();
            Console.WriteLine(new string('*', 5) + " " + "Restoran Menü Fiyatı" + " " + new string('*', 5));
            Console.WriteLine();

            int hamburgerCount, cokeCount, waterCount, friesCount, pizzaCount, lemonadeCount;
            int totalPrice = 0, totalHamburgerPrice = 0, totalCokePrice = 0, totalWaterPrice = 0, totalFriesPrice = 0, totalPizzaPrice = 0, totalLemonadePrice = 0;

            hamburgerCount = 3; cokeCount = 3; waterCount = 3; friesCount = 1; pizzaCount = 0; lemonadeCount = 0;
            totalPrice = (hamburgerCount * hamburgerPrice) + (cokeCount * cokePrice) + (waterCount * waterPrice) +
            (friesCount * friesPrice) + (pizzaCount * pizzaPrice) + (lemonadeCount * lemonadePrice);
            Console.WriteLine($"Toplam Fiyat: {totalPrice}" + " TL");

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            Console.WriteLine($"Toplam Hamburger Fiyatı: {totalHamburgerPrice}" + " TL");
            Console.WriteLine($"Toplam Kola Fiyatı: {totalCokePrice}" + " TL");
            Console.WriteLine($"Toplam Pizza Fiyatı: {totalPizzaPrice}" + " TL");
            Console.WriteLine($"Toplam Limonata Fiyatı: {totalLemonadePrice}" + " TL");
            Console.WriteLine($"Toplam Su Fiyatı: {totalWaterPrice}" + "  TL");
            Console.WriteLine($"Toplam Kızartma Fiyatı: {totalFriesPrice}" + " TL");
        }
        #endregion

        #region String  Değişkenler

        private static void StringDegiskenler()
        {
            //Değişkenler

            //string
            //değişken_türü değişken_adi

            string customerName = "Nazmiye", customerSurname = "KURBAN", customerPhone = "0555 555 55 55", customerEmail = "abc@gmail.com", district = "Başakşehir", city = "İstanbul";
            Console.WriteLine(new string('*', 5) + " " + "Rezervasyon Kartı" + " " + new string('*', 5));
            Console.WriteLine();
            Console.WriteLine(new string('-', 35));
            Console.WriteLine($"Müşteri: {customerName}" + $" {customerSurname}");
            Console.WriteLine($"İletişim: {customerPhone}");
            Console.WriteLine($"Email Adresi: {customerEmail}");
            Console.WriteLine($"Adres: {district}" + $" / {city}");
            Console.WriteLine(new string('-', 35));
            Console.WriteLine();
            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+90 400 300 80 70";
            customerEmail = "test@gmail.com";
            district = "Sapanca";
            city = "Sakarya";
            Console.WriteLine(new string('-', 35));
            Console.WriteLine($"Müşteri: {customerName}" + $" {customerSurname}");
            Console.WriteLine($"İletişim: {customerPhone}");
            Console.WriteLine($"Email Adresi: {customerEmail}");
            Console.WriteLine($"Adres: {district}" + $" / {city}");
            Console.WriteLine(new string('-', 35));
        }
        #endregion

        #region Yazdırma  Komutları

        private static void YazdirmaKomutlari()
        {
            //Console.WriteLine("Murat Hoca ile Yeniden C# Temel Konularına Başlıyoruz.");

            //Console.WriteLine("Selam");

            Console.WriteLine(new string('*', 5) + " " + "Yemek Kategorileri" + " " + new string('*', 5));
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine(new string('*', 5) + " " + "Yemek Kategorileri" + " " + new string('*', 5));
        }

        #endregion
    }
}
