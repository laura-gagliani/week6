using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsFigureGeometriche.Entita
{
     abstract class FiguraGeometrica
    {
        public double Area { get; set; }
        public double Perimetro { get; set; }

        public abstract double CalcolaPerimetro();
        public abstract double CalcolaArea();

        //TODO override to string generico
    }
}
