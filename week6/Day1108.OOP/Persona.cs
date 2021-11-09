using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1108.OOP
{
     class Persona
    {
        //proprietà 
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoDiNascita { get; set; }
        public DateTime DataDiNascita { get; set; }

        // questa, se private, non solo non passerà alla classe figlio, ma non sarà neanche accessibile dal program.
        //proprietà protected, invece: sarà accessibile dal program, ma solo relativamente alla classe Persona. non passa a Studente ? 
        private string Soprannome { get; set; } = "Pippo";


        //costruttore
        //il costruttore non è un altro che un METODO. un metodo speciale, che si chiama esattamente come la classe
        //a tutti gli effetti si comporta come un metodo: prende in input alcune/tutte le proprietà e rende un'istanza
        //public Persona (string nome, string cognome, int annoDiNascita, DateTime dataDiNascita)
        //{
        //    Nome = nome;
        //    Cognome = cognome;
        //    AnnoDiNascita = annoDiNascita;
        //    DataDiNascita = dataDiNascita;
        //}
        public Persona(string nome, string cognome, DateTime dataDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = dataDiNascita.Year;
            DataDiNascita = dataDiNascita;

        }
        //public Persona (string nome){
        //    Nome = nome;
        //}
        public Persona()
        {

        }


        //metodo
        public void Saluta()
        {
            Console.WriteLine($"Ciao, sono una PERSONA e mi chiamo {Nome}");
        }

        public override string ToString()
        {
            //return base.ToString();

            return $"persona: {Nome} {Cognome}";
        }

        //public abstract int CalcolaEta();

        public virtual void SalutaTutti()
        {
            Console.WriteLine("Ciao a tutti");
        }
    }
}
