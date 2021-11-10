using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsCalcio
{
    class Atleta
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }


        public Atleta()
        {

        }
        public Atleta(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }
    }
}
