﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler

            //For(x;y;z)
            //x: başlangıç değeri
            //y: bitişi tutar
            //z: artış/azalış miktarı

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 0; i<= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}
            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for(int i=0; i<=100; i++)
            //{
            //    if (i%5==0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;
            //for (int i=1; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);

            //int totalValue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++) 
            //{
            //    if (i % 7 == 0) 
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------------");
            //Console.WriteLine(count);

            //int bacteryCount = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacteryCount *= 2;
            //    Console.WriteLine($"{i}. Saat Sonunda: {bacteryCount}");
            //}

            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //işlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler!");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int totalValue = 0;
            //while (i <= 10)
            //{
            //    totalValue+=i;
            //    i++;
            //}
            //Console.WriteLine(totalValue);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //Console.Write("3 basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number / 10) % 10;
            //hundreds = number / 100;
            
            ////veya
            ////tens = (number % 100) / 10;

            ////Console.WriteLine(ones);
            ////Console.WriteLine(tens);
            ////Console.WriteLine(hundreds);

            //sum = ones + tens + hundreds;
            //Console.WriteLine($"{ones} + {tens} + {hundreds} = {sum}");



            #endregion

            Console.Read();
        }
    }
}
