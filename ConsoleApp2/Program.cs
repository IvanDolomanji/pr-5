using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //периметр треугольника


            //    Console.Write("a =");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.Write("b =");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.Write("c =");
            //    int c = int.Parse(Console.ReadLine());

            //    if (a < b + c && b < a + c && c < a + b)
            //    {
            //        double pp = (a + b + c) / 2;
            //        double s = Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c));
            //        Console.Write($"Треугольник существует\n{s:f2}");
            //    }
            //     else
            //    {
            //        Console.Write("Треугольника нет");
            //    }
            //    Console.Read();

            //квадатные уравнения


            Console.Write("a =");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b =");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c =");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Math.Pow(b,2)-4*a*c;
            if (d>0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b-Math.Sqrt(d)) / 2 * b;
                Console.WriteLine($"{x1}{x2}");
            }
            else if (d==0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2*a;
                Console.WriteLine($"{x1}");
            }
            else if (d<0)
            {
                Console.WriteLine("Нет корней");
            }
            Console.Read();
        }
    }
}
