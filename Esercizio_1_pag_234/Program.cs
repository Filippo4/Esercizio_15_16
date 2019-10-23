using System;

namespace Esercizio_1_pag_234
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int somma = 0;
            Leggi(ref n, ref somma);
            Console.WriteLine($"Hai inserito {n} numeri e la loro somma è {somma} ");
            Console.ReadLine();
        }

        static void Leggi(ref int count , ref int somma)
        {
            Console.WriteLine("inserisci un numero");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
                return;
            else
            {
                count++;
                somma += n;
                Leggi(ref count, ref somma);
            }
        }
    }
}
