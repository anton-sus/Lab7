using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("длина ребра куба = ");
            int a = Convert.ToInt32(Console.ReadLine());
            CalcArea(a);
            CalcVolume(a);
            Console.ReadKey();
        }
        static void CalcArea(int a)
        {
            int S = 6*a*a;
            Console.WriteLine("площадь поверхности = {0}",S);
        }
        static void CalcVolume(int a)
        {
            int V = (int)Math.Pow(a, 3);
            Console.WriteLine("объём = {0}", V);
        }
    }
}
