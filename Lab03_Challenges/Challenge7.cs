using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Challenges
{
    class Challenge7
    {
        public static void Read()
        {
            Console.WriteLine("The Content of 'Words.txt' is");
            String[] fileContent = File.ReadAllLines("Words.txt");
            for (int i = 0; i < fileContent.Length; i++)
                Console.WriteLine(fileContent[i]);
        }
    }
}
