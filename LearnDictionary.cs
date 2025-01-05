using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_
{
    internal class LearnDictionary
    {
        public static void GetDictionary()
        {
            Dictionary<string, int> studentAges = new Dictionary<string, int>();

            // Menambahkan elemen ke dictionary
            studentAges.Add("Alice", 20);
            studentAges.Add("Wall", 30);
            studentAges["Rabt"] = 30;

            // Mengakses elemen
            Console.WriteLine("Usia Alice: " + studentAges["Alice"]);

            if(studentAges.ContainsKey("Wall"))
            {
                Console.WriteLine("Diana ada di dalam dictionary.");
            } else
            {
                Console.WriteLine("Diana tidak ditemukan.");
            }

            // Iterasi semua elemen
            Console.WriteLine("\nDaftar semua mahasiswa:");
            foreach(var pair in studentAges)
            {
                Console.WriteLine($"Nama : {pair.Key}, Usia : {pair.Value}");
            }

            // Menghapus elemen
            studentAges.Remove("Rabt");
            Console.WriteLine("\nSetelah Bob dihapus:");

            // Menampilkan elemen setelah penghapusan
            foreach (var pair in studentAges)
            {
                Console.WriteLine($"Nama: {pair.Key}, Usia: {pair.Value}");
            }

            // Mendapatkan semua key dan value
            Console.WriteLine("\nSemua key:");
            foreach (var key in studentAges.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\nSemua value:");
            foreach (var value in studentAges.Values)
            {
                Console.WriteLine(value);
            }


        }
    }
}
