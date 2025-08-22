using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1ZuzkaConsoleApp1
{


    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("#BestVisma");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Best");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Visma");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
