using System;

namespace Calculadora
{
    class Program
    {
        static float Realizaroperacao(float numero1, float numero2, string operacao)
        {
            switch(operacao)
            {
                case "+": return numero1 + numero2;
                case "-": return numero1 - numero2;
                case "*": return numero1 * numero2;
                case "/": return numero1 / numero2;
                case "%": return numero1 % numero2;
                default: return 0f;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            var numero1string = Console.ReadLine();
            float numero1;
            bool teste1 = float.TryParse(numero1string, out numero1);
            if (!teste1)
            {
            Console.WriteLine("O primeiro número digitado não é valido.");
            return;
            }

            Console.WriteLine("Digite o segundo número: ");
            var numero2string = Console.ReadLine();
            float numero2;
            bool teste2 = float.TryParse(numero2string, out numero2);
            if (!teste2)
            {
            Console.WriteLine("O segundo número digitado não é valido.");
            return;
            }
            
            Console.WriteLine("Digite a operação que deseja fazer: ");
            var operacao = Console.ReadLine();

            float resultado = Realizaroperacao(numero1, numero2, operacao);
            Console.WriteLine("O resultado da sua operação é igual a " + resultado);

            }
    }
}
