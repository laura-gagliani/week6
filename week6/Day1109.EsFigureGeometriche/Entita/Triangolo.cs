using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsFigureGeometriche.Entita
{
     class Triangolo : FiguraGeometrica
    {
        public double Lato1 { get; set; }
        public double Lato2 { get; set; }
        public double Lato3 { get; set; }

        public Triangolo(double lato1, double lato2, double lato3)
        {
            Lato1 = lato1;
            Lato2 = lato2;
            Lato3 = lato3;
        }

        public override double CalcolaArea()
        {
            double p = CalcolaPerimetro() / 2;
            double prodIntermedio = p * (p - Lato1) * (p - Lato2) * (p - Lato3);
            return Math.Sqrt(prodIntermedio);
            

        }

        public override double CalcolaPerimetro()
        {
            return Lato1 + Lato2 + Lato3;
        }
    }
}
