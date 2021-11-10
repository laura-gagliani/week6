using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1110.Object.Equals__
{
    class Rettangolo
    {
        public int Base { get; set; }
        public int Altezza { get; set; }



        public override bool Equals(object obj) 

        {
            //io voglio l'override che mi accetti rettangoli uguali...
            Rettangolo rett = (Rettangolo)obj;

            return Base == rett.Base && Altezza == rett.Altezza;
        }
    }
}
