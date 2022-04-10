using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    class Challenge4
    {
        public static int GetMostRepeated(int[] arr)
        {
            int max = arr[0];

            foreach (int e in arr)
            {
                if (e > max)
                    max = e;
            }

            int[] temp = new int[max + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                temp[arr[i]]++;
            }

            int result = temp[0];
            int index = 1;

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] > result)
                {
                    result = temp[i];
                    index = i;
                }
            }
            return index == 1 ? arr[0] : index;
        }
    }
}
