using System;

namespace Day1108.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //qua ora ho due classi a disposizione.

            Persona p1 = new Persona();
            p1.Nome = "Renata";
            p1.Cognome = "Carriero";
            p1.AnnoDiNascita = 1987;
            p1.DataDiNascita = new DateTime(1987, 04, 01);
            p1.Saluta();

            //Persona p2 = new Persona("Alessandra", "Degan", 1980, new DateTime(1980, 04, 03));

            Persona p3 = new Persona("Mario", "Rossi", new DateTime(1963, 12, 12));
            Console.WriteLine($"mi chiamo {p3.Nome} e sono nato nell'anno {p3.AnnoDiNascita}");

            //Persona p4 = new Persona("Deborah");
            //Console.WriteLine($"{p4.Nome} - {p4.Cognome} - {p4.AnnoDiNascita} - {p4.DataDiNascita}");

            Studente s1 = new Studente();
            s1.Nome = "Valentina";
            s1.Cognome = "Loi";
            s1.AnnoDiNascita = 1988;
            s1.DataDiNascita = new DateTime(1988, 04, 02);

            s1.Matricola = 27949;

            p1.SalutaTutti();
            s1.Saluta(); // se io gli dico così il metodo è tal quale quello della classe padre!
            s1.SalutaTutti();

            Studente s2 = new Studente("Mario", "Rossi", new DateTime(1991, 03, 12)); // uso del costruttore ereditato
            Studente s3 = new Studente("Giuseppe", "Verdi", new DateTime(1993, 12, 08));
            Studente s4 = new Studente("Cicci", "Pasticci", new DateTime(1993, 12, 08));

            Console.WriteLine($" matricola s2: {s2.Matricola}; matricola s3: {s3.Matricola}");


            //ClasseStatica cs = new ClasseStatica(); // non la posso istanziare, mi dà errore!
            ClasseStatica.SalutaDaClasseStatica();



            //metodo VIRTUAL della classe Object, con sua implementazione base
            Console.WriteLine(s4.ToString());
            //posso andare a fare l'override dentro la classe Studente ! e poi chiamare

            
        }
    }
}
