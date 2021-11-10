using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsAzienda
{
    class Tecnico : Dipendente
    {
        public int PagaOraria { get; set; } = 10;
        public string CodiceFiscale { get; set; }


        public Tecnico()
        {

        }
        public Tecnico(string nome, string cognome, string codiceFiscale) : base(nome, cognome)
        {
            CodiceFiscale = codiceFiscale;
        }
        public Tecnico(string nome, string cognome, string codiceFiscale, int pagaOraria) : base(nome, cognome)
        {
            CodiceFiscale = codiceFiscale;
            PagaOraria = pagaOraria;
        }



        protected int CalcolaStipendio()
        {
            return PagaOraria * 40 *4;
        } 
        public override void StampaStipendio()
        {
            Console.WriteLine($"Lo stipendio è di {CalcolaStipendio()} euro mensili");
        }

        public new void StampaRuolo()
        {
            Console.WriteLine("Il ruolo è: Tecnico");
        }
        public override void StampaFerie()
        {
            //base.StampaFerie();
            Console.WriteLine("Il tecnico ha 3 giorni di ferie");
        }
    }
}
