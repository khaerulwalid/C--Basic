using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_
{
    internal class ArrayList
    {
        public static void mArrayList()
        {
            Console.WriteLine("=== Array ===");
            int[] numbersArray = { 5, 4, 3, 2, 1 };

            // menampilkan elemen array
            Console.WriteLine("Array Elements: " + string.Join(", ", numbersArray));

            Array.Sort(numbersArray);
            Console.WriteLine("Sorted Array: " + string.Join(", ", numbersArray));

            // Mencari elemen dalam array
            int searchValue = 8;
            bool contains = Array.Exists(numbersArray, elemen => elemen == searchValue);
            Console.WriteLine($"Array contains {searchValue}: {contains}");

            // Menghitung panjang array
            Console.WriteLine("Array Length : " + numbersArray.Length);

            // Mengakses elemen array
            Console.WriteLine("First Element: " + numbersArray[0]);
            Console.WriteLine("Last Element: " + numbersArray[numbersArray.Length - 1]);

            Console.WriteLine();

            // List
            Console.WriteLine("=== List ===");
            List<string> fruits = new List<string>();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");

            Console.WriteLine("List setelah Add:");
            PrintList(fruits);

            // Menyisipkan elemen
            fruits.Insert(1, "Mango");
            Console.WriteLine("\nList setelah Insert Mango di index 1:");
            PrintList(fruits);

            // Menghapus elemen
            fruits.Remove("Banana");
            Console.WriteLine("\nList setelah RemoveAt index 0:");
            PrintList(fruits);

            // Mengecek keberadaan elemen
            bool hasCherry = fruits.Contains("Cherry");
            Console.WriteLine($"\nApakah Cherry ada di List? {hasCherry}");

            // Mengurutkan elemen
            fruits.Sort();
            Console.WriteLine("\nList setelah Sort:");
            PrintList(fruits);

            // Mendapatkan jumlah elemen
            Console.WriteLine($"\nJumalah elemen dalam List: {fruits.Count}");




        }

        static void PrintList(List<string> list)
        {
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
