using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1110.ADO
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Titolo { get; set; }
        public int Durata { get; set; }
        public string Genere { get; set; }

        //noi ora non vogliamo più una lista che si finga DB... vogliamo un vero DB
        //creiamo un'interfaccia che conterrà tutti i metodi che deve avere il nostro Gestore
        //ie. tutti i metodi che abbiamo messo vuoti nel nostro menu


        public override string ToString()
        {
            return $"{FilmId} - {Titolo} - Genere: {Genere} - Durata: {Durata} minuti";
        }
    }
}
