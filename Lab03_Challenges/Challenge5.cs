using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    class Challenge5
    {
        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (int e in arr)
            {
                if (e > max)
                    max = e;
            }

            return max;
        }
    }
}
