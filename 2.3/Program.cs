using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double y;
                Console.WriteLine("Введите число x для всех вариантов параметров: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число (k), чтобы выбрать вариант параметров: ");
                double k = double.Parse(Console.ReadLine());
                if (k == 1)
                {
                    double a = 0.1;
                    Console.WriteLine($"Число a = {a}");
                    double b = 0.5;
                    Console.WriteLine($"Число b = {b}");
                    double z = Math.Exp(2.5 * a * x);
                    Console.WriteLine($"Число с = {z}");
                    switch (k)
                    {
                        case 1:
                            y = 3.5 * Math.Pow(Math.Sin(1), 2) * Math.Pow(b * x + z, 3) - Math.Exp(3.5 * a);
                            Console.WriteLine("При х<=a y равен: " + y);
                            break;
                        case 2:
                            y = Math.Log10(a + Math.Pow(b, 3) * x) + a;
                            Console.WriteLine("При a<x<=Math.Pow(b, 2.5) y равен: " + y);
                            break;
                        case 3:
                            y = Math.Pow(Math.Cos(1), 2) * ((Math.Pow(a, b)) + x * z) + Math.Pow(a, 2);
                            Console.WriteLine("При х>Math.Pow(b, 2.5) у равен: " + y);
                            break;
                    }
                }
                else if (k == 2)
                {
                    double a = 1.2;
                    Console.WriteLine($"Число a = {a}");
                    double b = 2.5;
                    Console.WriteLine($"Число b = {b}");
                    double z = Math.Exp(2.5 * a * x);
                    Console.WriteLine($"Число с = {z}");
                    switch (k)
                    {
                        case 1:
                            y = 3.5 * Math.Pow(Math.Sin(1), 2) * Math.Pow(b * x + z, 3) - Math.Exp(3.5 * a);
                            Console.WriteLine("При х<=a y равен: " + y);
                            break;
                        case 2:
                            y = Math.Log10(a + Math.Pow(b, 3) * x) + a;
                            Console.WriteLine("При a<x<=Math.Pow(b, 2.5) y равен: " + y);
                            break;
                        case 3:
                            y = Math.Pow(Math.Cos(1), 2) * ((Math.Pow(a, b)) + x * z) + Math.Pow(a, 2);
                            Console.WriteLine("При х>Math.Pow(b, 2.5) у равен: " + y);
                            break;
                    }
                }
                else if (k == 3)
                {
                    double a = 2.5;
                    Console.WriteLine($"Число a = {a}");
                    double b = 1.2;
                    Console.WriteLine($"Число b = {b}");
                    double z = Math.Exp(2.5 * a * x);
                    Console.WriteLine($"Число с = {z}");
                    switch (k)
                    {
                        case 1:
                            y = 3.5 * Math.Pow(Math.Sin(1), 2) * Math.Pow(b * x + z, 3) - Math.Exp(3.5 * a);
                            Console.WriteLine("При х<=a y равен: " + y);
                            break;
                        case 2:
                            y = Math.Log10(a + Math.Pow(b, 3) * x) + a;
                            Console.WriteLine("При a<x<=Math.Pow(b, 2.5) y равен: " + y);
                            break;
                        case 3:
                            y = Math.Pow(Math.Cos(1), 2) * ((Math.Pow(a, b)) + x * z) + Math.Pow(a, 2);
                            Console.WriteLine("При х>Math.Pow(b, 2.5) у равен: " + y);
                            break;
                    }
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}