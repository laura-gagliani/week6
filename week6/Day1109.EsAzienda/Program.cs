using System;
using System.Collections.Generic;

namespace Day1109.EsAzienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Stagista s = new Stagista("Giulio", "Verdi");

            Tecnico t = new Tecnico("Mario", "Rossi", "RSSMRI");

            Manager m = new Manager("Luca", "Bianchi", "BNCLCA", 20);

            //tutti i figli sono anche dipendenti; se dichiaro una var di tipo dipendente (NON un'istanza della classe dipendente, NB)
            //posso assegnargli il t tecnico, come s stagista...
            //ecco il POLIMORFISMO! posso trattarli come istanze della classe padre!!
            Dipendente d = t;

            List<Dipendente> dipendentiAzienda = new List<Dipendente>();
            dipendentiAzienda.Add(m);
            dipendentiAzienda.Add(s);
            dipendentiAzienda.Add(t);

            foreach (var item in dipendentiAzienda)
            {
                
                item.StampaDatiAnagrafici();
                item.StampaRuolo();
                item.StampaStipendio();
                Console.WriteLine("-------------");
            }
        }
    }
}
