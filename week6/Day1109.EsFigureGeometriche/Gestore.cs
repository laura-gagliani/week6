using Day1109.EsFigureGeometriche.Entita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsFigureGeometriche
{
    static class Gestore
    {
        static List<FiguraGeometrica> figure = new List<FiguraGeometrica>();
 
        internal static void AssegnaPerimetroEArea(FiguraGeometrica figura)
        {
            figura.Perimetro = Math.Round(figura.CalcolaPerimetro(), 2);
            figura.Area = Math.Round(figura.CalcolaArea(), 2);
        }

        internal static void AggiungiFiguraAElenco<T>(T figura) where T : FiguraGeometrica
        {
            foreach (var item in figure)
            {
                if (figura.Equals(item))
                {
                    //c'è già una stessa figura in lista
                }
            }
            figure.Add(figura);
        }
    }
}
