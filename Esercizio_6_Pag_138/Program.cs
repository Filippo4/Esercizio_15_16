using System;

namespace Esercizio_6_Pag_138
{
    class Program
    {
        static void Main(string[] args)
        {
            double sconto;
            double importoScontato;
            Console.WriteLine("inserire l'importo della spesa!");
            double importo = double.Parse(Console.ReadLine());
            if (importo < 50)
            {
                sconto = (importo / 100) * 5;
                
            }
            else if (importo > 50 && importo < 65)
            {
                sconto = (importo / 100) * 6;
                
            }
            else if(importo > 65 && importo < 80)
            {
                sconto = (importo / 100) * 7;
                
            }
            else
            {
                sconto = (importo / 100) * 10;
               
            }
            importoScontato = importo - sconto;
                Console.WriteLine($"lo sconto da applicare è di {sconto} l'importo da pagre è {importoScontato}");
        }
    }
}
