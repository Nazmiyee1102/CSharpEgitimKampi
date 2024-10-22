using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürün - Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz : ");
            tableNumber = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; initial Catalog = EgitimKampiDb; integrated Security = true;");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from TblCategory", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);//veri tabanıyla c# arasında köprü görevi sağlar
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            sqlConnection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write($" {item.ToString()}");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
