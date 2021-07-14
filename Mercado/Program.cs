using System;
using System.Collections.Generic;
using System.Linq;

namespace Mercado
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            List<string> produtosdisponiveis = new List<string>()
            {
                "pão", "leite", "manteiga", "requeijão", "refrigerante", "arroz", "alface", "tomate", "frango", "doce"
            };
            try
            {
                var produtoSelecionados = produtosdisponiveis.Where(produto => argumentos.Contains(produto)).ToList();
                foreach(var produtoSelecionado in produtoSelecionados)
                {
                    Console.WriteLine($"Este produtos nós temos: {produtoSelecionado}");
                }

                var produtosnaodisponiveis = argumentos.Where(argumentos => !produtosdisponiveis.Contains(argumentos)).ToList();
                foreach(var produtonaodisponivel in produtosnaodisponiveis)
                {
                    Console.WriteLine($"Este produtos nós não temos infelizmente =/ : {produtonaodisponivel}");
                }

                var produtosDisponiveisOrdenadosPorNome = produtosdisponiveis.OrderBy(e => e).ToList();
                foreach (var produtoOrdenado in produtosDisponiveisOrdenadosPorNome)
                {
                    Console.WriteLine($"Segue este produto disponível: ${produtoOrdenado}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Argumentos inválidos");
            }
        }
    }
}
