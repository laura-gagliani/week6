using System;

namespace Day1110.ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            // L'utente può: (Opzioni che saranno nel MENU)
            // Vedere tutti i film nella videoteca
            // Cercere i film per genere
            // Cercare i film per titolo
            // Cercare i film che hanno una durata minore di tot minuti
            // Cercare i film di un genere che hanno anche una durata maggiore di tot minuti
            // Stampare il numeri di film nella videoteca

            // Far scegliere all'utente i soli generi presenti
            // oppure gestire se non trova film con il genere inserito

            Console.WriteLine("Benvenuto nella Videoteca!");
            //DbManagerMock db = new DbManagerMock(); //  questo oggetto avrà la lista come proprietà e tutti i metodi
            DbManager db = new DbManager();

            bool quit = false;

            do
            {
                Console.WriteLine(".......... MENU ..........");
                Console.WriteLine("[1] Visualizza tutti i film nella videoteca");
                Console.WriteLine("[2] Cerca i film per genere");
                Console.WriteLine("[3] Cerca i film per titolo");
                Console.WriteLine("[4] Cerca i film che hanno durata minore di tot minuti");
                Console.WriteLine("[5] Cerca i film di un genere che hanno anche durata maggiore di tot minuti");
                Console.WriteLine("[6] Stampa il numero di film nella videoteca");
                Console.WriteLine("[7] Inserisci un nuovo film");
                Console.WriteLine("[8] Aggiorna la durata di un film");
                Console.WriteLine("[9] Elimina film");
                Console.WriteLine("[0] Esci");

                bool isInt;
                int choice;
                do
                {
                    Console.WriteLine("Seleziona dal menu:");
                    isInt = int.TryParse(Console.ReadLine(), out choice);
                } while (!isInt || choice < 0 || choice > 9);


                switch (choice)
                {
                    case 0:
                        quit = true;
                        Console.WriteLine("Chiusura in corso...");
                        break;

                    case 1:
                        Console.WriteLine("\nI film presenti sono:");
                        db.GetAllFilms();
                        break;

                    case 2:
                        Console.WriteLine("\nInserisci il genere desiderato:");
                        string genereCercato = Console.ReadLine();
                        db.GetFilmByGenere(genereCercato);
                        break;

                    case 3:
                        Console.WriteLine("\nInserisci il titolo desiderato:");
                        string titoloCercato = Console.ReadLine();
                        db.GetFilmByTitolo(titoloCercato);
                        break;

                    case 4:
                        Console.WriteLine("\nInserisci la durata massima (minuti) entro cui cercare:");
                        int durataMax = GetPositiveInt();
                        db.GetFilmByDurataMax(durataMax);
                        break;

                    case 5:
                        Console.WriteLine("\nInserisci il genere desiderato:");
                        string genereCercato2 = Console.ReadLine();
                        Console.WriteLine("\nInserisci la durata minima (minuti) entro cui cercare:");
                        int durataMin = GetPositiveInt();
                        db.GetFilmByGenereEDurataMin(genereCercato2, durataMin);
                        break;

                    case 6:
                        db.GetNumeroDiFilm();
                        break;

                    case 7:
                        Console.WriteLine("\nInserisci il titolo:");
                        string titolo = Console.ReadLine();
                        Console.WriteLine("\nInserisci il genere:");
                        string genere = Console.ReadLine();
                        Console.WriteLine("\nInserisci la durata:");
                        int durata = GetPositiveInt(); 
                        db.InserisciFilm(titolo, genere, durata);
                        break;

                    case 8:
                        Console.WriteLine("\nInserisci l'ID del film di cui aggiornare la durata:");
                        int idCercato = GetPositiveInt();
                        Console.WriteLine("\nInserisci la nuova durata:");
                        int nuovaDurata = GetPositiveInt();
                        db.ModificaDurataFilm(idCercato, nuovaDurata);
                        break;

                    case 9:
                        Console.WriteLine("\nInserisci l'ID del film da eliminare:");
                        int idEliminando = GetPositiveInt();
                        db.EliminaFilm(idEliminando);
                        break;
                }


            } while (!quit);
        }

        private static int GetPositiveInt()
        {
            bool isInt;
            int num;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out num);

            } while (!isInt || num <= 0);

            return num;
        }
    }
}
