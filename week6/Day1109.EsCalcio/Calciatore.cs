using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsCalcio
{
    class Calciatore : Atleta
    {
        public RuoloEnum Ruolo { get; set; }
        public int NumeroMaglia { get; set; }


        public Calciatore()
        {

        }
        public Calciatore(string nome, string cognome, int eta, int numeroMaglia, RuoloEnum ruolo) :base(nome, cognome, eta)
        {
            NumeroMaglia = numeroMaglia;
            Ruolo = ruolo;
        }



        public enum RuoloEnum
        {
            Attaccante,
            Centrocampista,
            Difensore,
            Portiere
        }


        public override string ToString()
        {
            //return base.ToString();
            return $"Maglia n. {NumeroMaglia} - {Nome} {Cognome} - ruolo {Ruolo}";
        }
    }
}
