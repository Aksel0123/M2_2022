using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Pravougulnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a =double.Parse(Console.ReadLine());
            double b =double.Parse(Console.ReadLine());

            double area = a * b;
            double p = 2 * a + 2 * b;
            double d=Math.Sqrt(a*a+b*b);

            Console.WriteLine(area);
            Console.WriteLine(p);
            Console.WriteLine(d);
        }
    }
}
