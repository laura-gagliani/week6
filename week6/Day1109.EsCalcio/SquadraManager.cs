using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day1109.EsCalcio.Calciatore;

namespace Day1109.EsCalcio
{
    static class SquadraManager
    {


        public static void AddCalciatore(Calciatore c, List<Calciatore> squadra)
        {
            //prende input squadra, calciatore e dice se il tale calciatore (con suo ruolo) può essere aggiunto o meno alla squadra
            if (PossoInserirlo(c, squadra))
            {
                squadra.Add(c);
            }

            else
            {
                Console.WriteLine($"Errore nell'aggiunta di {c.Cognome}. Raggiunto il numero massimo per il ruolo di {c.Ruolo}");
            }
        }

        private static bool PossoInserirlo(Calciatore c, List<Calciatore> squadra)
        {
            var numeroRuoliPerSquadra = new Dictionary<RuoloEnum, int>
            {
                {RuoloEnum.Portiere, 1 },
                {RuoloEnum.Attaccante, 2 },
                {RuoloEnum.Centrocampista, 4 },
                {RuoloEnum.Difensore, 4 },
            };

            int count = 0;

            foreach (var item in squadra)
            {
                if (item.Ruolo == c.Ruolo)
                {
                    count++;
                }
            }

            if (count < numeroRuoliPerSquadra[c.Ruolo])
            {
                return true;
            }
            else return false;

        }
    }
}
