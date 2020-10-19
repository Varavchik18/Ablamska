using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 5;
            double value = 1;
            for (int i = 0; i <= Count; i++)
            {
                value = Math.Pow(2, 64) - 1;
            }

            Console.WriteLine("Count seed's = "+ value);
            Console.ReadLine();
        }
    }
}
