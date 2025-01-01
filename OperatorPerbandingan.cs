using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_
{
    public class OperatorPerbandingan
    {
        public static void OperatorPerbandingaMethod()
        {
            Console.WriteLine("=== Operator Perbandingan dan Logika===");

            Console.WriteLine("Masukkan nilai pertama: ");
            int valueA= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan nilai kedua: ");
            int valueB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=== Operator Perbandingan ===");
            Console.WriteLine($"valueA == valueB : {valueA == valueB}");
            Console.WriteLine($"valueA != valueB : {valueA != valueB}");  // Tidak samvalueAdengan
            Console.WriteLine($"valueA > b  : {valueA > valueB}");   // Lebih besar
            Console.WriteLine($"valueA < b  : {valueA < valueB}");   // Lebih kecil
            Console.WriteLine($"valueA >= valueB : {valueA >= valueB}");  // Lebih besar atau sama
            Console.WriteLine($"valueA <= valueB : {valueA <= valueB}");  // Lebih kecil atau sama

            Console.WriteLine("\n=== Operator Logika ===");

            // Contoh operator logika
            Console.WriteLine($"(a > b) && (a != b): {(valueA > valueB) && (valueA != valueB)}"); // AND
            Console.WriteLine($"(a < b) || (a == b): {(valueA < valueB) || (valueA == valueB)}"); // OR
            Console.WriteLine($"!(a == b)          : {!(valueA == valueB)}");          // NOT
        }
    }
}
