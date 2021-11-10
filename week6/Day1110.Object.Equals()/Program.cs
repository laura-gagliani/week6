using System;

namespace Day1110.Object.Equals__
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            bool verificaConfronto = (a == b); // in questo caso il bool sarà false

            string s1 = "ciao";
            string s2 = "ciao";
            bool verifica = (s1 == s2); //sarà true

            a.Equals(b); // mi rende un bool di controllo a seconda dell'effettiva eguaglianza

            Console.WriteLine($"confronto con == : {s1 == s2 }");
            Console.WriteLine($"confronto con .Equals() : {s1.Equals(s2) }");

            Rettangolo r1 = new Rettangolo();
            r1.Base = 10;
            r1.Altezza = 2;

            Rettangolo r2 = new Rettangolo();
            r2.Base = 10;
            r2.Altezza = 2;

            Rettangolo r3 = new Rettangolo();
            r3.Altezza = 5;
            r3.Base = 7;

            Console.WriteLine("miei tipi: \n");
            Console.WriteLine($"confronto con == per due istanze r1, r2 : {r1 == r2 }");
            Console.WriteLine($"confronto con .Equals(), che ho ridefinito : {r1.Equals(r2) }");
            //Con


            Console.WriteLine("\n\nconfronto array: \n");
            int[] a1 = new int[] { 1, 2, 3 };
            int[] a2 = new int[] { 1, 2, 3 };
            int[] a3 = a1;
            Console.WriteLine($"confronto con == : {a1 == a2 }");
            Console.WriteLine($"confronto con .Equals() : {a1.Equals(a2) }");

            Console.WriteLine($"confronto con == : {a1 == a3 }");
            Console.WriteLine($"confronto con .Equals() : {a1.Equals(a3) }");


        }


    }
}
