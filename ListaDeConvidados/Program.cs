using System;

namespace Desktop
{
    class Program
    {
        private static string [] ListaConvidados = {
            "Daniel",
            "Rafael",
            "Evandro",
            "Marcelo",
            "Victor",
            "Pamela"
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do convidado: ");
            var nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome) || nome == null)
            {
                Console.WriteLine("Digite um nome válido.");
                return;
            }

            Console.WriteLine("Digite a idade do convidado: ");
            var idadestring = Console.ReadLine();
            int idade;

            bool teste = int.TryParse(idadestring, out idade);
            if (teste == false)
            {
                Console.WriteLine("O número digitado não é uma idade. ");
                return;
            }

            bool estaconvidado;
            switch(nome)
            {
                case "Daniel" :
                    estaconvidado = true;
                break; 
                case "Rafael" :
                    estaconvidado = true;
                break; 
                case "Evandro" :
                    estaconvidado = true;
                break; 
                case "Marcelo" :
                    estaconvidado = true;
                break; 
                case "Victor" :
                    estaconvidado = true;
                break; 
                case "Pamela" :
                    estaconvidado = true;
                break; 
                default:
                    estaconvidado = false;
                break;
            }

            if(estaconvidado == true && idade >= 18)
            {
                Console.WriteLine("Pode entrar na festa, Está na lista de convidado! ");
            }
            else if (estaconvidado == false)
            {
                Console.WriteLine("Desculpe mas você não está na lista de convidados! ");

            }
            else
            {
                Console.WriteLine("Você não tem idade para esta festa! ");
            }
        }
    }
}
