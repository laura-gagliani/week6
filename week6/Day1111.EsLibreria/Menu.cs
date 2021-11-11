using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1111.EsLibreria
{
    class Menu
    {
        internal static void Start()
        {
            // Il proprietario può:
            // vedere tutti i libri stampando titolo, autore e se è o no audiolibro
            // vedere tutta la lista di libri cartacei
            // vedere tutta la lista di audiolibri
            // Modificare la quantità di libri cartacei in magazzino
            // Modificare la durata in minuti di un audiolibro
            // Cercare per titolo tutti i film (Se inserisce un titolo gli viene mostrato sia il libro cartaceo che l'audiolibro)
            
            //MockManagerAudioBooks dbAudioBooks = new MockManagerAudioBooks();
            //MockManagerPaperBooks dbPaperBooks = new MockManagerPaperBooks();
            DbManagerPaperBooks dbPaperBooks = new DbManagerPaperBooks();
            DbManagerAudioBooks dbAudioBooks = new DbManagerAudioBooks();


            bool quit = false;

            do
            {
                Console.WriteLine(".......... MENU ..........");
                Console.WriteLine("[1] Visualizza tutti i libri (audiolibri e cartacei)");
                Console.WriteLine("[2] Visualizza la lista di libri cartacei");
                Console.WriteLine("[3] Visualizza la lista di audiolibri");
                Console.WriteLine("[4] Modifica la quantità di libri cartacei in magazzino");
                Console.WriteLine("[5] Modifica la durata in minuti di un audiolibro");
                Console.WriteLine("[6] Cerca per titolo (sia tra audiolibri che tra cartacei)");
                Console.WriteLine("[7] Inserisci un nuovo libro");
                Console.WriteLine("[0] Esci");

                int choice = GetMenuInt(0, 7);

                switch (choice)
                {
                    case 0:
                        quit = true;
                        Console.WriteLine("Chiusura in corso...");
                        break;

                    case 1:
                        List<PaperBook> list1 = dbPaperBooks.GetBooks();
                        List<AudioBook> list2 = dbAudioBooks.GetBooks();
                        List<Book> listTot = new List<Book>();
                        listTot.AddRange(list1);
                        listTot.AddRange(list2);

                        foreach (var item in listTot)
                        {
                            //Stampa
                        }
                        break;

                    case 2:
                        List<PaperBook> listPaper = dbPaperBooks.GetBooks();
                        foreach (var item in listPaper)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;

                    case 3:
                        List<AudioBook> listAudio = dbAudioBooks.GetBooks();
                        foreach (var item in listAudio)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nInserisci codice del libro:");
                        int code = GetInt();
                        Console.WriteLine("\nInserisci nuova quantità:");
                        int quantity = GetInt();
                        PaperBook selectedBook = dbPaperBooks.FindBookByISBN(code);
                        //TODO : control codice corretto
                        dbPaperBooks.ModifyStockQuantity(selectedBook, quantity);

                        break;

                    case 5:
                        //Stampa libri audio con durata
                        // get book by code -> passa dato al db?

                        //book.ModifyDuration
                        break;

                    case 6:
                        Console.WriteLine("\nInserisci il titolo cercato:");
                        string title = Console.ReadLine();
                        AudioBook foundAudiobook = dbAudioBooks.FindBookByTitle(title);
                        PaperBook foundPaperbook = dbPaperBooks.FindBookByTitle(title);
                        if(foundPaperbook != null)
                        {
                            Console.WriteLine(foundPaperbook.ToString());

                        }
                        if (foundAudiobook != null)
                        {
                            Console.WriteLine(foundAudiobook.ToString());

                        }

                        break;

                    case 7:
                        Console.WriteLine("\nSeleziona il tipo di libro che vuoi aggiungere:");
                        Console.WriteLine("\n1. Libro cartaceo");
                        Console.WriteLine("\n2. Audiolibro");
                        int bookType = GetMenuInt(1, 2);

                        switch (bookType)
                        {
                            case 1:

                                PaperBook newPaperBook = CreatePaperBookFromInput();

                                dbPaperBooks.AddBook(newPaperBook);
                                break;

                            case 2:
                                AudioBook newAudioBook = CreateAudioBookFromInput();
                                
                                dbAudioBooks.AddBook(newAudioBook);
                                break;
                        }

                        break;

                }


            } while (!quit);
        }

        private static AudioBook CreateAudioBookFromInput()
        {
            Console.WriteLine("\nInserisci il codice ISBN:");
            int code = GetInt();
            //TODO: controllo code univoco
            Console.WriteLine("\nInserisci il titolo:");
            string titolo = Console.ReadLine();
            Console.WriteLine("\nInserisci l'autore:");
            string autore = Console.ReadLine();

            
            Console.WriteLine("\nInserisci la durata (minuti):");
            int durata = GetInt();

            AudioBook newBook = new AudioBook(code, titolo, autore, durata);
            return newBook;
        }

        private static PaperBook CreatePaperBookFromInput()
        {
            Console.WriteLine("\nInserisci il codice ISBN:");
            int code = GetInt();
            //TODO: controllo code univoco
            Console.WriteLine("\nInserisci il titolo:");
            string titolo = Console.ReadLine();
            Console.WriteLine("\nInserisci l'autore:");
            string autore = Console.ReadLine();

            Console.WriteLine("\nInserisci il numero di pagine:");
            int numPagine = GetInt();
            Console.WriteLine("\nInserisci la quantità in magazzino:");
            int qtaMagazzino = GetInt();

            PaperBook newBook = new PaperBook(code, titolo, autore, numPagine, qtaMagazzino);
            return newBook;
        }

        private static int GetMenuInt(int min, int max)
        {
            bool isInt;
            int num;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out num);

            } while (!isInt || num < min || num > max);

            return num;
        }

        private static int GetInt()
        {
            bool isInt;
            int num;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out num);

            } while (!isInt || num < 0);

            return num;
        }
    }
}
