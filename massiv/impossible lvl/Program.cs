using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impossible_lvl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = { 2, 1, 3, 5 };
            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write($"{masiv[i]} ");
            }
            Console.ReadKey();
        }
    }
}
