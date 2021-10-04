using System;

namespace Converter
{
    class Converter
    {
        public double usd, eur;
        public Converter(double usd, double eur)
        {
            this.usd = usd;
            this.eur = eur;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input usd/uah course");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input eur/uah course");
            double eur = Convert.ToDouble(Console.ReadLine());
            Converter converter = new Converter(usd, eur);
            while(true)
            {
                Console.WriteLine("Input amount in uah");
                double uah = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you want to convert into usd or into eur?");
                string money_type = Console.ReadLine();
                if(money_type == "usd")
                {
                    Console.WriteLine("Your amount in usd: {0}", uah/converter.usd);
                }
                else if(money_type == "eur")
                {
                    Console.WriteLine("Your amount in eur: {0}", uah / converter.eur);
                }
                else
                {
                    Console.WriteLine("Error: Unknown command");
                }
            }
        }
    }
}
