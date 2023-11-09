using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samostoialka
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.Write("Число вводится в куб");
            int step = 3;
            Console.WriteLine($"Число {x} в степени {step} = " + Math.Pow(x,step));
            Console.ReadKey();

        }
    }
}
