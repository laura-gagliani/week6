using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsFigureGeometriche.Entita
{
     class Cerchio : FiguraGeometrica
    {
        public double Raggio { get; set; }

        public Cerchio(double raggio)
        {
            Raggio = raggio;
        }

        public override double CalcolaPerimetro()
        {
            return 2d * 3.14 * Raggio;
        }

        public override double CalcolaArea()
        {
            return Raggio * Raggio * 3.14;
        }
    }
}
