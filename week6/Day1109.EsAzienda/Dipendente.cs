using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsAzienda
{
    abstract class Dipendente //la facciamo astratta: in questo caso istanzieremo solo tecnico, stagista, manager
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Dipendente() //costruttore vuoto
        {

        }
        public Dipendente(string nome, string cognome) //costruttore parametri base
        {
            this.Nome = nome; //in caso di ambiguità si usa il this. per fargli capire qual è la proprietà di QUESTA classe 
            Cognome = cognome;
        }

        public void StampaDatiAnagrafici() //questo me lo implemento già qua
        {
            Console.WriteLine($"Nome: {Nome}\t Cognome: {Cognome}");
        }

        public void StampaRuolo() //lo facciamo "normale", faremo il NEW nella classe 
        {
            Console.WriteLine("Il ruolo è: Dipendente");
        }

        public abstract void StampaStipendio(); //è questo che conviene mettere abstract, perché "non ha senso" definirlo nella classe padre

        public virtual void StampaFerie() 
        {
            Console.WriteLine("Il dipendente ha 2 giorni di ferie");
        }
    }
}
