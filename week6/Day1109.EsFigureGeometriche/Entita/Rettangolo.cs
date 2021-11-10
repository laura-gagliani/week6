using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsFigureGeometriche.Entita
{
     class Rettangolo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public Rettangolo(double b, double h)
        {
            Base = b;
            Altezza = h;
        }

        public override double CalcolaArea()
        {
            return Base * Altezza;
        }

        public override double CalcolaPerimetro()
        {
            return (Base + Altezza) * 2;
        }
    }
}
