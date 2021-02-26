using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class CalcMath
    {// Métodos para invocar na Class Form1

        public int x; // o x é um value member da class calcMath, mas foi incorretamente especificado como Public
        public int y; // o y é um value member da class calcMath, mas foi incorretamente especificado como Public

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                x = value;
            }
        }

        public int Somar()
        {
            return x + y;
        }

        public int Multiplicar()
        {
            return x * y;
        }

    }
}
