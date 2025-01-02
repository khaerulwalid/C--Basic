using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_
{
    internal class SwitchCase
    {
        public static void getDay()
        {
            Console.Write("Masukkan angka antara 1 dan 7: ");
            int day = int.Parse(Console.ReadLine());

            switch(day)
            {
                case 1:
                    Console.WriteLine("Hari Senin");
                    break;
                case 2:
                    Console.WriteLine("Hari Selasa");
                    break;
                case 3:
                    Console.WriteLine("Hari Rabu");
                    break;
                case 4:
                    Console.WriteLine("Hari Kamis");
                    break;
                case 5:
                    Console.WriteLine("Hari Jum'at");
                    break;
                case 6:
                    Console.WriteLine("Hari Sabtu");
                    break;
                case 7:
                    Console.WriteLine("Hari Sabtu");
                    break;
                default:
                    Console.WriteLine("Angka yang dimasukkan tidak valid. Harap masukkan angka antara 1 dan 7.");
                    break;

            }
        }
    }
}
