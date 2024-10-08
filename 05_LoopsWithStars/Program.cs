﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma                           

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}



            #endregion

            #region Yan yana 10 tane yıldız oluşturma                           

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun                          

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik üçgen                                        

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (global::System.Int32 j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters Dik üçgen                                        

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (global::System.Int32 j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Elmas                                        

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (global::System.Int32 j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for (global::System.Int32 l = 1; l <= k; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava                                      

            //int n = 5;


            ////üst kısım
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (global::System.Int32 k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////alt kısım
            //for (int i = n - 1; i >= 1; i--)
            //{ 

            //    for (global::System.Int32 j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (global::System.Int32 k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit                                        

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (global::System.Int32 j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k < 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters Piramit                                        

            int n = 5;

            for (int i = n; i >= 1; i--)
            {
                for (global::System.Int32 j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            #endregion


            Console.Read();
        }
    }
}