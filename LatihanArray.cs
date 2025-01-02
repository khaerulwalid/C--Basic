using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_
{
    internal class LatihanArray
    {
        public static object slice(List<string> data = null, int? start = null, int? end = null)
        {
            if(data == null)
            {
                return "Invalid Data";
            }

            List<string> dataBaru = new List<string>();

            if(start.HasValue && start.Value > data.Count)
            {
                return dataBaru;
            }

            if(!start.HasValue)
            {
                return data;
            }

            int nilai = end ?? data.Count;

            //for(int i = 0; i < nilai - start.Value; i++)
            //{
            //    dataBaru.Add(data[start.Value + i]);
            //}

            int i = 0;
            while(i < nilai - start.Value)
            {
                dataBaru.Add(data[start.Value + i]);
                i++;
            }


            return dataBaru;
        }
    }
}
