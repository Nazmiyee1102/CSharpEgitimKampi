using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CRUD --> Create, Read, Update, Delete 

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            #region Create

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection sqlConnection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = EgitimKampiDb; integrated Security = true");
            //sqlConnection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values  (@p1)", sqlConnection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //sqlConnection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek istediğiniz ürün adı : ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());



            //SqlConnection sqlConnection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = EgitimKampiDb; integrated Security = true");
            //sqlConnection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values  (@productName, @productPrice, @productStatus)", sqlConnection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //sqlConnection.Close();

            //Console.WriteLine("Ürün başarıyla eklendi.");
            #endregion



            #endregion

            #region Read

            #region Ürün Listeleme 

            //SqlConnection sqlConnection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = EgitimKampiDb; integrated Security = true");
            //sqlConnection.Open();

            //SqlCommand command = new SqlCommand("select * from TblProduct", sqlConnection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);//sql le bağlantıyı sağlar.
            //DataTable dataTable = new DataTable();//verileri geçici hafızaya almak için
            //adapter.Fill(dataTable);//içini doldurmak için

            ////verileri kullanıcıya göstermek için;
            //foreach (DataRow row in dataTable.Rows)//satırın tamamı
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write($" {item.ToString()} ");
            //    }
            //    Console.WriteLine();
            //}

            //sqlConnection.Close();



            #endregion

            #endregion

            #region Update

            //Ürün Güncelleme İşlemi

            Console.Write("Güncellecek Ürün Id : ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellecek Ürünün Adı : ");
            string productName = Console.ReadLine();

            Console.Write("Güncellecek Ürün Fiyatı : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = EgitimKampiDb; integrated Security = true");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("update TblProduct set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId", sqlConnection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            sqlConnection.Close();

            Console.WriteLine("Güncelleme işlemi yapıldı");



            #endregion

            #region Delete

            //Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id : ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection sqlConnection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = EgitimKampiDb; integrated Security = true");
            //sqlConnection.Open();

            //SqlCommand command = new SqlCommand("delete from TblProduct where ProductId = @productId", sqlConnection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //sqlConnection.Close();

            //Console.WriteLine("Silme işlemi yapıldı");

            #endregion


            Console.Read();
        }
    }
}
