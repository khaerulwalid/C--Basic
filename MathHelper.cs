using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_
{
    internal class MathHelper
    {
        public static string getMax(int[] numbers)
        {
            int max = int.MinValue;

            foreach(int number in numbers)
            {
                if(number > max)
                {
                    max = number;
                }
            }

            return $"Nilai maksimum adalah {max}";
        }
    }
}
