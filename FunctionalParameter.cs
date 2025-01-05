using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_
{
    internal class FunctionalParameter
    {
        delegate int MathOperation(int x, int y);
        public static void GetFunctionalParameter()
        {
            PerformOperation(5, 10, (a, b) => a + b);
            PerformOperation(5, 10, (a, b) => a * b);
        }

        static void PerformOperation(int x, int y, Func<int, int, int> operation)
        {
            int result = operation(x, y);
            Console.WriteLine($"Result: {result}");
        }
    }
}
