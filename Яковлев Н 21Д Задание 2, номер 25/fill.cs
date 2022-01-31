﻿//Задание 2
//Окружность, геометрическая фигура, линия, заливка
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Яковлев_Н_21Д_Задание_2__номер_25
{
    internal class fill : geo_figure
    {
        private int _degree;

        public fill(int length, int quantity) : base(length, quantity)
        {

        }

        public fill(int length, int width, int degree) : base(length, width)
        {
            _degree = degree;
        }

        public int Degree { get => _degree; set => _degree = value; }
    }
}
