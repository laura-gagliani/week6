using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1110.ADO
{
    class DbManagerMock : IDbManager
    {

        //classe manager usata fino ad ora, dovrei avrei messo
        // la lista "finto db" dove aggiungere i miei film
        // tutti i metodi gestionali (implementati dall'interfaccia)

        static List<Film> films = new List<Film>()
         {
             new Film{FilmId = 1, Titolo = "Titanic", Genere="Storico", Durata=240},
             new Film{FilmId = 2, Titolo = "Peter Pan", Genere="Animazione", Durata=60}
         };

        public void EliminaFilm(int filmId)
        {
            throw new NotImplementedException();
        }

        //la lascio static, la considero una proprietà "di classe"

        public void GetAllFilms()
        {
            foreach (var item in films)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void GetFilmByDurataMax(int durataMax)
        {
            throw new NotImplementedException();
        }

        public void GetFilmByGenere(string genere)
        {
            foreach (var item in films)
            {
                if (item.Genere == genere)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public void GetFilmByGenereEDurataMin(string genere, int durataMin)
        {
            throw new NotImplementedException();
        }

        public void GetFilmByTitolo(string titolo)
        {
            throw new NotImplementedException();
        }

        public void GetNumeroDiFilm()
        {
            throw new NotImplementedException();
        }

        public void InserisciFilm(string titolo, string genere, int durata)
        {
            throw new NotImplementedException();
        }

        public void ModificaDurataFilm(int filmId, int nuovaDurata)
        {
            throw new NotImplementedException();
        }
    }
}
