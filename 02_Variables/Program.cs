using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            ////Double değişkenler
            ////double number = 5.4;
            ////Console.WriteLine($"Sayı: {number}");

            //Console.WriteLine(new string('*',5) + "  Fiyat Listesi  " + new string('*',5));
            //Console.WriteLine();

            //double applePrice = 14.85, orangePrice = 20.95, strawberryPrice = 45, potatoPrice = 9.74, tomatoPrice = 6.88;

            //Console.WriteLine($"----- Elma Fiyatı: {applePrice}" + " TL");
            //Console.WriteLine($"----- Portakal Fiyatı: {orangePrice}" + " TL");
            //Console.WriteLine($"----- Çilek Fiyatı: {strawberryPrice}" + " TL");
            //Console.WriteLine($"----- Patates Fiyatı: {potatoPrice}" + " TL");
            //Console.WriteLine($"----- Domates Fiyatı: {tomatoPrice}" + " TL");
            //Console.WriteLine();
            //Console.WriteLine();
            //double appleGram = 1.245, orangeGram = 2.650, strawberryGram = 0.750, potatoGram = 4.859, tomatoGram = 3.745;

            //double totalApplePrice = appleGram * applePrice;
            //Console.WriteLine($"Alınan Ürün: Elma - Birim Fiyat: {applePrice} - Gramaj: {appleGram} - Toplam Fiyat: {totalApplePrice}");
            //double totalOrangePrice = orangeGram * orangePrice;
            //Console.WriteLine($"Alınan Ürün: Portakal - Birim Fiyat: {orangePrice} - Gramaj: {orangeGram} -  Toplam Fiyat: {totalOrangePrice}");
            //double totalStrawberryPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine($"Alınan Ürün: Çilek - Birim Fiyat: {strawberryPrice} - Gramaj: {strawberryGram} -  Toplam Fiyat: {totalStrawberryPrice}");
            //double totalPotatoPrice = potatoGram * potatoPrice;
            //Console.WriteLine($"Alınan Ürün: Patates - Birim Fiyat: {potatoPrice} - Gramaj: {potatoGram} -  Toplam Fiyat: {totalPotatoPrice}");
            //double totalTomatoPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine($"Alınan Ürün: Domates - Birim Fiyat: {tomatoPrice} - Gramaj: {tomatoGram} -  Toplam Fiyat: {totalTomatoPrice}");
            //double shoppingPrice = totalApplePrice + totalOrangePrice + totalStrawberryPrice + totalPotatoPrice + totalTomatoPrice;
            //Console.WriteLine($"Toplam Alışveriş Tutarı: {shoppingPrice}");

            #endregion

            #region Char Değişkenler

            //char symbol = 'a';
            //Console.WriteLine($"Sembol: {symbol}");

            #endregion

            #region Klavyeden Veri Girişleri - String Değişkenler         

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, 
            //    passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcunun Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcunun Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcunun İlçesi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcunun Şehri: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcunun Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcunun TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine($"Hayırlı Yolculuklar Dileriz {passengerName} {passengerSurname}...");

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler          

            //int shoesPrice = 1000, computerPrice = 20000, chairPrice = 5000, televisionPrice = 12000;

            //int shoesCount , computerCount, chairCount, televisionCount;

            //Console.Write("Lütfen aldığınız ayakkabı adedini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar adedini giriniz: ");
            //computerCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye adedini giriniz: ");
            //chairCount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon adedini giriniz: ");
            //televisionCount = Convert.ToInt32(Console.ReadLine());

            //int totalPrice = (shoesCount * shoesPrice) + (computerCount * computerPrice) + 
            //    (chairCount * chairPrice) + (televisionCount * televisionPrice);

            //Console.WriteLine($"Toplam Alışveriş Tutarınız: {totalPrice} TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri      

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //if (result >= 45)
            //    Console.WriteLine($"Ortalamanız {result}. Dersi ortalamanın üzerinden geçtiniz.");
            //else 
            //    Console.WriteLine($"Ortalamanız {result}. Dersten kaldınız. Dersi tekrar almanız gerekecek.");

            #endregion

            #region Klavyeden Karakter Girişi      

            char gender;
            Console.Write("Lütfen cinsiyetinizi seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine($"Seçtiğiniz Cinsiyet: {gender}");

            #endregion

            Console.Read();
        }
    }
}
