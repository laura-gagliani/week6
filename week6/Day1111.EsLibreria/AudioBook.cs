using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1111.EsLibreria
{
    public class AudioBook : Book 
    {
        public int Durata { get; set; }


        public AudioBook (int isbn, string titolo, string autore, int durata) :base( isbn, titolo, autore)
        {
            Durata = durata;
        }
        
        public AudioBook()
        {

        }

        public override string ToString()
        {
            return $"ISBN: {ISBN} - {Titolo} di {Autore} - Durata: {Durata} minuti";
        }



    }
}
