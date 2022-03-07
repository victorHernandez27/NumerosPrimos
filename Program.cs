using System;

namespace NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, cont = 0;

            Console.WriteLine("Digite um número");

            do
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("Coloque um valor não negativo!");
                }

            } while(n<0);

            

            for(int i = n; i > 0; i--)
            {
                if(n % i == 0)
                {
                    cont++;
                }
            }

            if(cont > 2)
            {
                Console.WriteLine("Não é Primo");
            }
            else
            {
                Console.WriteLine("É Primo");
            }

            Console.ReadKey();
        }
    }
}
