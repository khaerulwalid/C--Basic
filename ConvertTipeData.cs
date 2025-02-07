﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_
{
    internal class ConvertTipeData
    {
        static void Main(String[] args)
        {
            //CountChar countChar = new CountChar();

            //// Contoh pemanggilan getChar dengan parameter
            //string text = "This is a sample text with some f's";
            //char target = 'f';

            //string result = countChar.getChar(text, target);

            //// Tampilkan hasil
            //Console.WriteLine(result);


            //// PROGRAM MENCARI ANGKA TERTINGGI
            //int[] numbers = { 1, 4, 2, 1, 51, 67, 8, 32, 21, 97, 65 };

            //string result1 = MathHelper.getMax(numbers);

            //Console.WriteLine(result1);


            //var data1 = new List<string> { "ant", "bison", "camel", "duck", "elephant" };

            //Console.WriteLine(string.Join(", ", LatihanArray.slice(data1, 2) as List<string>)); // [ 'camel', 'duck', 'elephant' ]
            //Console.WriteLine(string.Join(", ", LatihanArray.slice(data1, 2, 4) as List<string>)); // [ 'camel', 'duck' ]
            //Console.WriteLine(string.Join(", ", LatihanArray.slice(data1, 1, 5) as List<string>)); // [ 'bison', 'camel', 'duck', 'elephant' ]
            //Console.WriteLine(string.Join(", ", LatihanArray.slice(data1) as List<string>)); // [ 'ant', 'bison', 'camel', 'duck', 'elephant' ]
            //Console.WriteLine(string.Join(", ", LatihanArray.slice(data1, 20) as List<string>)); // []
            //Console.WriteLine(LatihanArray.slice() as string); // Invalid data

            // ArrayList.cs
            ArrayList.mArrayList();

            // Dictionary.cs
            LearnDictionary.GetDictionary();

            // FunctionalParameter.cs
            FunctionalParameter.GetFunctionalParameter();
        }
        public static void Conversi()
        {
            Console.WriteLine("=== Program Demonstrasi Konversi Tipe Data ===");

            // Contoh Convert.ToInt32()
            Console.Write("\nMasukkan sebuah angka (akan dikonversi ke int): ");
            string inputInt = Console.ReadLine();

            try
            {
                int resultInt = Convert.ToInt32(inputInt);
                Console.WriteLine($"Konversi berhasil, Hasil int : {resultInt}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input bukan format angka valid untuk int.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Angka terlalu besar atau kecil untuk tipe int.");
            }

            Console.Write("\nMasukkan sebuah angka desimal (akan dikonversi ke double): ");
            string inputDouble = Console.ReadLine();

            try
            {
                double resultDouble = Convert.ToDouble(inputDouble);
                Console.WriteLine($"Konversi berhasil! Hasil double: {resultDouble}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input bukan format angka valid untuk double.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Angka terlalu besar atau kecil untuk tipe double.");
            }

            // Contoh Convert.ToString()
            Console.Write("\nMasukkan data apapun (akan dikonversi ke string): ");
            object inputObject = Console.ReadLine();

            string resultString = Convert.ToString(inputObject);
            Console.WriteLine($"Konversi berhasil! Hasil string: \"{resultString}\"");

            // Contoh TryParse
            Console.Write("\nMasukkan sebuah angka (TryParse ke int): ");
            string inputTryParse = Console.ReadLine();
            if (int.TryParse(inputTryParse, out int parsedInt))
            {
                Console.WriteLine($"TryParse berhasil! Hasil int: {parsedInt}");
            }
            else
            {
                Console.WriteLine("TryParse gagal! Input bukan angka yang valid untuk int.");
            }


            Console.WriteLine("\n=== Program Selesai ===");
        }
    }
}
