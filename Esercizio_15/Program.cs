using System;

namespace Esercizio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire l'altezza");
            double l1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserire la base");
            double l2 = double.Parse(Console.ReadLine());
            if (l1==l2)
            {
                double perimetro = l1 * 4;
                double area = l1 * l2;
                Console.WriteLine("il quadrilatero è un quadrato!");
                Console.WriteLine($"l'area è {area} il perimetro è {perimetro}!");
            }
            else
            {
                double perimetro = ( l1 + l2 ) * 2;
                double area = l1 * l2;
                Console.WriteLine("il quadrilatero è un rettangolo!");
                Console.WriteLine($"l'area è {area} il perimetro è {perimetro}!");
            }
            Console.ReadLine();
        }
    }
}
