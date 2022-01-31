//Задание 2
//Окружность, геометрическая фигура, линия, заливка
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Яковлев_Н_21Д_Задание_2__номер_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            geo_figure p = new geo_figure(500000, 20);
            Console.WriteLine(p.ToString());

            Circle Circle = new Circle(10000, 5, 15);
            Console.WriteLine(Circle.ToString());

            line line = new line(20000, 10, 10);
            Console.WriteLine(line.ToString());

            fill fill = new fill(30000, 5, 5);
            Console.WriteLine(fill.ToString());

            Console.ReadKey();
        }
    }
}
