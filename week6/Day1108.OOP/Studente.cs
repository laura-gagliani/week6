using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1108.OOP
{
    class Studente : Persona
    {
        //proprietà: vogliamo che abbia tutte le proprietà che abbiamo già definito in Persona!!

        //e poi avrà membri (proprietà e metodi)
        public int Matricola { get; set; }
        public static int MatricolaPartenza { get; set; } = 10000;
        

        public Studente()
        {

        }
        public Studente(string nome, string cognome, DateTime dataDiNascita) : base(nome, cognome, dataDiNascita)
        {
            // gli sto dicendo guarda voglio un costruttore che prenda questi parametri che ti dico.
            // come li devi associare? invece che RIDIRGLIELO, gli dico guarda vai in base e fai come per quei parametri lì

            Matricola = MatricolaPartenza; // il parametro in più dello studente glielo posso specificare!
            MatricolaPartenza++; //avendolo messo STATICO resta "fisso", visibile per ogni nuovo uso del costruttore
        }



        public override void SalutaTutti()
        {
            Console.WriteLine("Ciao a tutti -firmato studente");
        }

        public new void Saluta()
        {
            Console.WriteLine($"Ciao, sono uno STUDENTE e mi chiamo {Nome}");
        }

        public override string ToString()
        {
            //return base.ToString(); //questa è l'implementazione base! base.Tostring()

            return $"{Matricola} - {Nome} - {Cognome}";
            //fatto questo override il metodo chiamato farà la nuova istruzione
        }

        public /*override*/ int CalcolaEta()
        {
            return DateTime.Today.Year-AnnoDiNascita;
        }
    }
}
