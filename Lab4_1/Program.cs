using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.WriteLine("Vvedite znachenie");
            n = Convert.ToInt32(Console.ReadLine());
            for (int x = 1; x < 2 * n; x += 2)
            {
                sum += x;
                Console.WriteLine("kvadrat raven {0}", sum);
            }
            Console.ReadKey();
        }
    }
}
