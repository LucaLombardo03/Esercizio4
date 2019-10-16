using System;

namespace esercizio_sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            double sconto = 0;
            Console.Write("Inserisci l'importo della spesa:  ");
            double importo = double.Parse(Console.ReadLine());
            if (importo > 100)
            {
                sconto = (importo / 100) * 20;
                sconto = importo - sconto;
            }
            Console.Write("L'importo scontato è {0:c}", sconto);
            Console.ReadLine();
        }
    }
}
