using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1111.EsLibreria
{
    public class MockManagerPaperBooks : IPaperBooks
    {
        static List<PaperBook> paperBooks = new List<PaperBook>()
        {
            new PaperBook {ISBN = 789, Titolo = "Pinocchio", Autore = "Collodi", NumeroPagine = 340, QuantitaMagazzino = 20},
            new PaperBook (900, "I tre moschettieri", "Dumas", 400, 15),
            new PaperBook (909, "Il conte di Montecristo", "Dumas", 453, 8),
        };

        public void AddBook(PaperBook item)
        {
            paperBooks.Add(item);
        }

        public PaperBook FindBookByISBN(int code)
        {
            foreach (var item in paperBooks)
            {
                if (item.ISBN == code)
                    return item;
            }

            return null;
        }

        public PaperBook FindBookByTitle(string title)
        {
            foreach (var item in paperBooks)
            {
                if (item.Titolo == title)
                    return item;
            }

            return null;
        }

        public List<PaperBook> GetBooks()
        {
            return paperBooks;
        }

        public void ModifyStockQuantity(PaperBook item, int quantity)
        {
            item.QuantitaMagazzino = quantity;
        }
    }
}
