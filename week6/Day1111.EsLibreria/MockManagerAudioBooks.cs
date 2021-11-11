using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1111.EsLibreria
{
    public class MockManagerAudioBooks : IAudioBooks
    {
        static List<AudioBook> audioBooks = new List<AudioBook>()
        {
            new AudioBook (134, "Guerra e Pace", "Tolstoj", 3000),
            new AudioBook (654, "Kobane Calling", "Zerocalcare", 200),
            new AudioBook (357, "Il signore degli anelli", "Tolkien", 2700),
            new AudioBook (264, "Il piccolo principe", "de Saint-Exupery", 120)
        };

        public void AddBook(AudioBook item)
        {
            throw new NotImplementedException();
        }

        public AudioBook FindBookByISBN(int code)
        {
            throw new NotImplementedException();
        }

        public AudioBook FindBookByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<AudioBook> GetBooks()
        {
            return audioBooks;
        }

        public void ModifyDuration()
        {
            throw new NotImplementedException();
        }
    }
}
