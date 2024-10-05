using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else                   

            #region Örnek1  
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();

            //if (password == "abcd") 
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Şifreyi yanlış girdiniz tekrar deneyiniz.");
            //}
            #endregion

            #region Örnek2   
            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz : ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}

            //else
            //{
            //    Console.WriteLine("Hatalı bilgi.");
            //}
            #endregion

            #region Örnek3      

            //Console.Write("Sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            #endregion

            #region Örnek4     

            //Console.Write("1. Sınav notunuz: ");
            //double exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav notunuz: ");
            //double exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav notunuz: ");
            //double exam3 = double.Parse(Console.ReadLine());

            //double average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine($"Sınavların Ortalaması : {average}");
            //string result = "Hata!";

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if (average > 84 )
            //{
            //    result = "Sonuç Çok İyi";
            //}



            //Console.WriteLine(result);

            #endregion

            #region Örnek5   

            //Console.Write("Şehrinizi girin: ");
            //string city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "bayburt")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}

            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil.");
            //}

            #endregion

            #region Örnek6   

            //Console.Write("Kullanıcı Adı : ");
            //string userName = Console.ReadLine();

            //if (userName != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}

            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}

            #endregion

            #endregion

            #region Mod İşlemleri    

            //int number = 26, result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen sayıyı girin: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Modunu almak istediğiniz sayı: ");
            //int mod = int.Parse(Console.ReadLine());

            //int result = number % mod;

            //Console.WriteLine($"Mod : {result}");

            #endregion

            #region Tek Mi Çift Mi              

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}

            //else
            //{
            //    Console.Write("Sayı tektir");
            //}

            #endregion

            #region Klavyeden Giriş Alma                                     

            //Console.Write("Harf girin: ");
            //char harf = char.Parse(Console.ReadLine());

            //if (harf == 'f' | harf == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (harf == 'g' | harf == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (harf == 'b' | harf == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            //else
            //{
            //    Console.WriteLine("Böyle bir takım bulunmamaktadır. Tekrar deneyebilirsiniz.");
            //}

            #endregion

            #region Menü Sayfası Oluşturma             

            //Console.WriteLine("**** C# Eğitim Kampı Restoranı ****");
            //Console.WriteLine();
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine();


            //Console.Write("Lütfen bir seçim yapınız: ");
            //string menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Ana Yemekler");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Makarna");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Soğan");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Çorbalar");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Düğün Çorbası");
            //    Console.WriteLine("3- Ezogelin Çorbası");

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Pizzalar");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margharitha");
            //    Console.WriteLine("3- Tavuklu Pizza");

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("İçecekler");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Tatlılar");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Trileçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");

            //}



            #endregion

            #region Switch - Case                

            //Console.Write("Ayını öğrenmek istediğiniz rakamı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //switch (number)
            //{
            //    case 1:
            //        Console.Write("Ocak");
            //        break;
            //    case 2:
            //        Console.Write("Şubat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayıs");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Ağustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylül");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasım");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;

            //    default:
            //        Console.WriteLine("Böyle bir ay değeri bulunmuyor.");
            //        break;
            //}





            #endregion

            #region Hesap Makinesi              

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. sayı: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayı: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi seçin : ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine($"Toplam : {result}");
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine($"Fark : {result}");
            //        break;
            //        case '*':
            //            result = number1 * number2;
            //        Console.WriteLine($"Çarpım : {result}");
            //        break;
            //        case '/':
            //            result = number1 / number2;
            //        Console.WriteLine($"Bölüm : {result}");
            //        break;
            //    default:
            //        Console.WriteLine("Böyle bir işlem mümkün değil");
            //        break;
            //}



            #endregion

            

            Console.Read();

        }
    }
        
    
}
