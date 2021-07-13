using System;

namespace Repetição
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            if(argumentos.Length == 0)
            {
                Console.WriteLine("Favor informar palavras no argumento");
                return;
            }
            //for 
            for (var indice = 0; indice < argumentos.Length; indice++)
            {
                Console.WriteLine($"Estrutura for, indice e valor: {indice}, {argumentos[indice]}");
            }

            //while
            var argumentosLidos = 0;
            while(argumentosLidos < argumentos.Length)
            {
                Console.WriteLine($"Estrutura while, argumentosLidos e valor lido: {argumentosLidos}, {argumentos[argumentosLidos]}");            
                argumentosLidos++;    
            }
            //do while
            var argumentosLidos2 = 0;
            do
            {
                Console.WriteLine($"Estrutura do while, argumentosLidos e valor lido: {argumentosLidos2}, {argumentos[argumentosLidos2]}");            
                argumentosLidos2++;    
            } while(argumentosLidos2 < argumentos.Length);
            
            //foreach
            foreach(var argumentosLidos3 in argumentos)
            {
                Console.WriteLine($"Estrutura do foreach, valor lido: {argumentosLidos3}");      
            }
        }
    }
}
 