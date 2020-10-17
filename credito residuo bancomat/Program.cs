using System;

namespace credito_residuo_bancomat
{
    class Program
    {
        static void Main(string[] args)
        {
            double contatore = 0;
            Console.WriteLine("inserire credito iniziale:");
            double credito = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("inserire numero di acquisi effettuati:");
            double acquisti = Convert.ToDouble(Console.ReadLine());
            while (acquisti > contatore)
            {
                Console.WriteLine("inserire spesa:");
                double spesa = Convert.ToDouble(Console.ReadLine());
                if (credito >= spesa)
                {
                     credito = credito - spesa;
                    Console.WriteLine($"il tuo credito residuo è: {credito}");
                } 
                else 
                {
                     credito = credito - spesa;
                    Console.WriteLine($"la spesa inserita scende sotto di: {credito}, impossibile applicare la spesa!!");
                    
                    {
                        double risarcimento = credito + spesa;
                        Console.WriteLine($"la spesa non viene effettuata e dunque il tuo credito rimane invariato");
                        Console.WriteLine($"il tuo credito residuo è: {risarcimento}");
                    }          
                } 
                contatore++;
            } // francesco billardello, 3B inf.

        

        }
    }
}

