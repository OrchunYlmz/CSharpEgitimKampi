﻿using System;
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

            //DeğişkenTürü [] DiziAdı = new DeğşkenTürü [ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[1]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[7]);
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    } 
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int number = myArray[0];
            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > number)
            //    {
            //        number=myArray[i];
            //    }
            //}
            //Console.WriteLine(number);

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 41, 52, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 41, 52, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine($"Dizinin En Büyük Elemanı: {numbers.Max()}, Dizinin En Küçük Elemanı: {numbers.Min()}");


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"{i+1}.Şehir adını girin: ");
            //    cities[i]= Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            ////numbers.Sum();

            //int[] numbers = { 220 ,21, 42, 33, 54, 55, 66, 897, 748, 39 };
            //int[] evenNumbers = { };
            //int[] oddNumbers = { };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0) 
            //    {
            //        evenNumbers= evenNumbers.Append(numbers[i]).ToArray();
            //    }
            //    else
            //    {
            //        oddNumbers= oddNumbers.Append(numbers[i]).ToArray();
            //    }
            //}
            //for (int i = 0;i < evenNumbers.Length; i++)
            //{
            //    Console.WriteLine($"Çiftler: {evenNumbers[i]}");
            //}
            //Console.WriteLine("--------------------");

            //for (int i = 0; i < oddNumbers.Length; i++)
            //{
            //    Console.WriteLine($"Tekler: {oddNumbers[i]}");
            //}

            //int[] numbers = { 220, 21, 42, 33, 54, 55, 66, 897, 748, 39 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1) //!=0 da olur
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
