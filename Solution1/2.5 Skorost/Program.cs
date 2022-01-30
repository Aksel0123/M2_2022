using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5_Skorost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float memters=float.Parse(Console.ReadLine());
            float h=float.Parse(Console.ReadLine());
            float m=float.Parse(Console.ReadLine());
            float s=float.Parse(Console.ReadLine());

            float time=h*3600+m*60+s;
            float ms = memters / time;
            Console.WriteLine(Math.Round(ms,7));

            float km = memters / 1000.0f;
            float chas = time / 3600.0f;
            Console.WriteLine(Math.Round(km/chas,6));

            float milq = memters / 1609.0f;
            Console.WriteLine(Math.Round(milq/chas,6));
        }
    }
}
