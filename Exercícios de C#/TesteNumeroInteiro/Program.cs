using System;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Digite um número válido. ");
                return;
            }
            int numero;
            bool teste = int.TryParse(args[0], out numero);
            if (teste == false)
            {
                Console.WriteLine("O número digitado não é um número inteiro ");
            }

            Console.WriteLine("O número digitado foi " + numero);
        }
    }
}
