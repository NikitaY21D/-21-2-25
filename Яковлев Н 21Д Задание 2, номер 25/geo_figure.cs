//Задание 2
//Окружность, геометрическая фигура, линия, заливка
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Яковлев_Н_21Д_Задание_2__номер_25
{
    internal class geo_figure
    {
        private int _length;
        private int _width;

        public geo_figure(int cost, int quantity)
        {
            _length = Length;
            _width = Width;
        }

        public geo_figure()
        {
        }

        public int Length { get => _length; set => _length = value; }
        public int Width { get => _width; set => _width = value; }

        public override string ToString()
        {
            return _length + " " + _width;
        }
    }
}
