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

            Console.WriteLine("Benvenuto nella videoteca!");

            bool quit = false;

            do
            {
                Console.WriteLine(".......... MENU ..........");
                Console.WriteLine("[1] vedere tutti i film nella videoteca");
                Console.WriteLine("[2] Cercere i film per genere");
                Console.WriteLine("[3] Cercare i film per titolo");
                Console.WriteLine("[4] Cercare i film che hanno una durata minore di tot minuti");
                Console.WriteLine("[5] Cercare i film di un genere che hanno anche una durata maggiore di tot minuti");
                Console.WriteLine("[6] Stampare il numeri di film nella videoteca");
                Console.WriteLine("[0] Esci");

                bool isInt;
                int choice;
                do
                {
                    Console.WriteLine("Seleziona dal menu:");
                    isInt = int.TryParse(Console.ReadLine(), out choice);
                } while (!isInt || choice < 0 || choice > 6);


                switch (choice)
                {
                    case 0:
                        quit = true;
                        Console.WriteLine("Chiusura in corso...");
                        break;

                    case 1:
                        
                        break;

                    case 2:
                        break;

                    case 3:
                        break;
                }


            } while (!quit);
        }
    }
}
