using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asanior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int p=int.Parse(Console.ReadLine());

            int coure = n / p;
            int ost = n % p;
            if (ost>0)
            {
                coure++;
            }
            Console.WriteLine(coure);

            Console.WriteLine("************");

            int kurs =(int)Math.Ceiling((double)coure);
            Console.WriteLine(kurs);
        }
    }
}
