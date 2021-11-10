using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsAzienda
{
    class Stagista : Dipendente
    {
        public int CompensoMensile { get; set; } = 600;

        public Stagista(string nome, string cognome) :base( nome, cognome)
        {

        }
        public Stagista(string nome, string cognome, int compensoMensile) :base(nome, cognome)
        {
            CompensoMensile = compensoMensile;
        }
        public Stagista()
        {

        }


        public override void StampaStipendio()
        {
            Console.WriteLine("Lo stipendio dello stagista {0} {1} è di {2} euro al mese", Nome, Cognome, CompensoMensile);
        }

        public new void StampaRuolo()
        {
            Console.WriteLine("Il ruolo è: Stagista");
        }

        public override void StampaFerie()
        {
            //base.StampaFerie();
            Console.WriteLine("Lo stagista ha 5 giorni di ferie");
        }
    }
}
