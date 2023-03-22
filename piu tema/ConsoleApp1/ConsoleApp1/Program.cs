using System;
using System.Configuration;



using ConsoleApp1;


namespace GSM_bun
{
    class Program
    {
        static void Main(string[] args)
        {

            string optiune;
            do
            {
                Console.WriteLine("C. Citire produs de la tastatura");
                Console.WriteLine("D. Citire furnizor de la tastatura");
                Console.WriteLine("A. Cautare produs dupa nume");
                Console.WriteLine("V. Cautare furnizor dupa nume");
                Console.WriteLine("F. Afisare produselor din fisier");
                Console.WriteLine("W. Afisare furnizorilor din fisier");
                Console.WriteLine("S. Salvare produs in fisier");
                Console.WriteLine("M. Salvare furnizor in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
               