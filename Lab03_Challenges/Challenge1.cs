using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    class Challenge1
    {
        public static void Start()
        {
            Console.WriteLine("Enter numbers seperated by space");
            string input = Console.ReadLine();
            int result = Multiplying(input);

            Console.WriteLine("The product of these 3 numbers is: " + result);
        }

        public static int Multiplying(string input)
        {
            string[] numbers = input.Split(" ");

            if (numbers.Length < 3)
                return 0;

            int result = 1;
            int x;

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    x = Convert.ToInt32(numbers[i]);
                }
                catch
                {
                    continue;
                }

                result *= x;
            }

            return result;
        }
    }
}
