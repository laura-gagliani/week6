using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsAzienda
{
    class Manager : Tecnico
    {
        public int BonusMensile { get; set; } = 1000;


        public Manager()
        {

        }
        public Manager(string nome, string cognome, string codiceFiscale, int pagaOraria) :base(nome,cognome, codiceFiscale, pagaOraria)
        {

        }
        public Manager(string nome, string cognome, string codiceFiscale, int pagaOraria, int bonusMensile) : base(nome, cognome, codiceFiscale, pagaOraria)
        {
            BonusMensile = bonusMensile;
        }

        private new int CalcolaStipendio()
        {
            return base.CalcolaStipendio() + BonusMensile;
        }
        public override void StampaStipendio()
        {
            //Console.WriteLine($"Lo stipendio è di {CalcolaStipendio()+BonusMensile} euro mensili ");
            base.StampaStipendio();
        }
        public override void StampaFerie()
        {
            Console.WriteLine("Il manager ha 4 giorni di ferie");
        }
    }
}
