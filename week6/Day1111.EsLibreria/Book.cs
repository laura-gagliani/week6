using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1111.EsLibreria
{
    abstract public class Book
    {
        public int ISBN { get; set; }
        public string Titolo { get; set; }

        public string Autore { get; set; }


        public Book(int isbn, string titolo, string autore)
        {
            ISBN = isbn;
            Titolo = titolo;
            Autore = autore;
        }

        public Book()
        {

        }
    }
}
