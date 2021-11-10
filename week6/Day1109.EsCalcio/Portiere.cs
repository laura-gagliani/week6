using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsCalcio
{
    class Portiere : Calciatore
    {
        public int GoalSubiti { get; set; } = 0;


        public Portiere()
        {

        }
        public Portiere(string nome, string cognome, int eta/*, int numeroMaglia, RuoloEnum ruolo, int goalSubiti*/) :base(nome, cognome, eta, 1, RuoloEnum.Portiere)
        {

        }
    }
}
