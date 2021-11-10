using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1109.EsCalcio
{
    class Attaccante : Calciatore
    {
        public int GoalFatti { get; set; }


        public Attaccante(string nome, string cognome, int eta, int numeroMaglia)
            :base(nome, cognome, eta, numeroMaglia, RuoloEnum.Attaccante)
        {

        }
    }
}
