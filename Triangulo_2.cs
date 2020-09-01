using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathOrientada
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Areas()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
