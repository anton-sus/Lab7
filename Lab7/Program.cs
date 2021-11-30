using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задайте 2 треугольника длинами их сторон");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double S1 = CalcArea(x1, y1, z1);
            double S2 = CalcArea(x2, y2, z2);
            if (S1!=S2)
            {
                if (S1 > S2)
                {
                    Console.WriteLine("S1 > S2");
                }
                else
                {
                    Console.WriteLine("S2 > S1");
                }
            }
            else
            {
                Console.WriteLine("S1 = S2");
            }
            Console.ReadKey();
        }
        static double CalcArea(double x, double y, double z)
        {
            double p = (x + y + z)/2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }
}
