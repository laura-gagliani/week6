using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1111.EsLibreria
{
    public class PaperBook : Book
    {
        public int NumeroPagine { get; set; }
        public int QuantitaMagazzino { get; set; }

        public PaperBook(int isbn, string titolo, string autore, int numeroPagine, int quantita) :base (isbn, titolo, autore)
        {
            NumeroPagine = numeroPagine;
            QuantitaMagazzino = quantita;
        }
        
        public PaperBook()
        {

        }


        public override string ToString()
        {
            return $"ISBN: {ISBN} - {Titolo} di {Autore} - {NumeroPagine} pagine - Copie in magazzino: {QuantitaMagazzino}";
        }

    }
}
