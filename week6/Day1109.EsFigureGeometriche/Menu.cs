using Day1109.EsFigureGeometriche.Entita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Day1109.EsFigureGeometriche
{
    class Menu
    {
        internal static void Start()
        {
            bool quit = false;

            do
            {
                Console.WriteLine(".......... MENU FORME ..........");
                Console.WriteLine("[1] Inserisci figura in elenco");
                Console.WriteLine("[1] Visualizza tutte le figure in elenco");
                Console.WriteLine("[2] Stampa perimetro di tutte le figure in elenco");
                Console.WriteLine("[3] Stampa area di tutte le figure in elenco");
                Console.WriteLine("[0] Esci");

                bool isInt;
                int choice;
                do
                {
                    Console.WriteLine("Seleziona dal menu:");
                    isInt = int.TryParse(Console.ReadLine(), out choice);
                } while (!isInt || choice < 0 || choice > 3);


                switch (choice)
                {
                    case 0:
                        quit = true;
                        Console.WriteLine("Chiusura in corso...");
                        break;

                    case 1:
                        InserisciForma();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;
                }





            } while (!quit);

        }

        private static void InserisciForma()
        {
            Console.WriteLine("Scegli una delle possibili figure:");
            Console.WriteLine("1. Cerchio");
            Console.WriteLine("2. Rettangolo");
            Console.WriteLine("3. Quadrato");
            Console.WriteLine("4. Triangolo");

            bool isInt;
            int choice;
            do
            {
                Console.WriteLine("Seleziona dal menu:");
                isInt = int.TryParse(Console.ReadLine(), out choice);
            } while (!isInt || choice < 1 || choice > 4);


            FiguraGeometrica figuraScelta = InserisciDati(choice);
            Gestore.AssegnaPerimetroEArea(figuraScelta);
            Gestore.AggiungiFiguraAElenco(figuraScelta);


        }

        private static FiguraGeometrica InserisciDati(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Inserisci il raggio:");
                    double r = InserisciDato();

                    Cerchio c = new Cerchio(r);
                    return c;

                case 2:
                    Console.WriteLine("Inserisci la base:");
                    double b = InserisciDato();
                    Console.WriteLine("Inserisci l'altezza:");
                    double h = InserisciDato();

                    Rettangolo rett = new Rettangolo(b, h);
                    return rett;


                case 3:
                    Console.WriteLine("Inserisci il lato:");
                    double lato = InserisciDato();

                    Quadrato quadr = new Quadrato(lato);
                    return quadr;


                case 4:
                    Console.WriteLine("Inserisci il primo lato:");
                    double lato1 = InserisciDato();
                    Console.WriteLine("Inserisci il secondo lato:");
                    double lato2 = InserisciDato();
                    Console.WriteLine("Inserisci il terzo lato:");
                    double lato3 = InserisciDato();

                    Triangolo triang = new Triangolo(lato1, lato2, lato3);
                    return triang;
            }
            return null;
        }

        private static double InserisciDato()
        {
            bool isDouble;
            double dato;

            do
            {
                isDouble = double.TryParse(Console.ReadLine(), out dato);
            } while (!isDouble || dato <= 0);

            return dato;
        }
    }







}


