using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_
{
    internal class CountChar
    {
        public string getChar(string text, char target)
        {
            int count = text.Count(c => c == target);

            return $"Text ini memiliki {count} huruf {target}";
        }
    }
}
