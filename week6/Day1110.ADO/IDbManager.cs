using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1110.ADO
{
    public interface IDbManager
    {

        // qui praticamente mettiamo la "lista" di tutti i metodi che dovranno essere eseguibili sul mio db
        // li passerò quindi ad una mia classe FilmManager
        
        public void GetAllFilms();
        
        public void GetFilmByTitolo(string titolo);
        
        public void GetFilmByGenere(string genere);

        /// <summary>
        /// Restituisce i film con durata minore di un tot (=durataMax)
        /// </summary>
        /// <param name="durataMax"></param>
        public void GetFilmByDurataMax(int durataMax);

        /// <summary>
        /// Restituisce film con genere dato(=genere) e durata maggiore di un tot(=durataMin)
        /// </summary>
        /// <param name="genere"></param>
        /// <param name="durataMin"></param>
        public void GetFilmByGenereEDurataMin(string genere, int durataMin);

        public void GetNumeroDiFilm();

        public void InserisciFilm(string titolo, string genere, int durata);

        public void ModificaDurataFilm(int filmId, int nuovaDurata);

        public void EliminaFilm(int filmId);
    }
}
