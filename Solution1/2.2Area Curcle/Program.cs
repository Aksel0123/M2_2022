using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2Area_Curcle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r=double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            Console.WriteLine(Math.Round(area,12));
        }
    }
}
