using System;

namespace Esercizio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il primo lato");
            double l1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il secondo lato");
            double l2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire il terzo lato");
            double l3 = double.Parse(Console.ReadLine());
            if (l1 == l2 && l1==l3)
            {
                double perimetro = l1 * 3;
                double h = (Math.Sqrt(3) / 2) * l1;
                double area = (l1 * h) / 2;
                Console.WriteLine("il triangolo è equilatero!");
                Console.WriteLine($"l'area è {area} il perimetro è {perimetro}!");

            }else
            {
                Console.WriteLine("il triangolo non è equilatero!");
            }
        }
    }
}
