using System;
using System.Collections.Generic;
using System.Linq;
using ListaDeAnimais.Classes;
namespace ListaDeAnimais
{
    /*
        Escrever um programa  - OK
        Que recebe um nome de animal vertebrada - OK 
        De acordo com um filtro, identifica a qual dos grupos ele pertence (Mamifero, Réptil, Ave e Peixe) - OK 
        E exibir os dados genéricos e exclusivos de cada grupo animal - OK
    */
    class Program
    {
        //Escrever um programa  - OK
        static void Main(string[] argumentos)
        {
            // Que recebe um nome de animal vertebrada - OK 
            Console.WriteLine("Favor informar o nome do animal: ");
            var NomeAnimal = Console.ReadLine();
            if(string.IsNullOrEmpty(NomeAnimal) || string.IsNullOrWhiteSpace(NomeAnimal))
            {
                Console.WriteLine("Favor passar um nome de animal vertebrado válido!");
                return;
            }
            // Recebe uma lista de animais
            var ListaDeAnimais = new List<Animal>();
            ListaDeAnimais.Add(new Mamifero() {Nome= "Vaca", QuantidadeDeMamas = 4});
            ListaDeAnimais.Add(new Reptil() {Nome= "Cobra"});
            ListaDeAnimais.Add(new Ave() {Nome= "Gavião"});
            ListaDeAnimais.Add(new Peixe() {Nome= "Tubarão", QuantidadeNadadeiras =2});

            // Compara se o animal digitado é igual o da lista
            var animalSelecionado = ListaDeAnimais.FirstOrDefault(animal => animal.Nome.ToUpper() == NomeAnimal.ToUpper());

            // Se não for nenhum da lista
            if(animalSelecionado == null)
            {
                Console.WriteLine("O animal não está na nossa lista!");
                return;
            }

            //Se o animal digitado for um desses identificado mostra suas especificações
            if(animalSelecionado is Mamifero)
            {
                Console.WriteLine($"O animal encontrado é um mamífero com nome {animalSelecionado.Nome} e quantidade de mamas = {((Mamifero)animalSelecionado).QuantidadeDeMamas}");
            } else if(animalSelecionado is Reptil)
            {
                Console.WriteLine($"O animal encontrado é um reptil com nome {animalSelecionado.Nome} e não sabe controlar sua temperatura  = {((Reptil)animalSelecionado).ControlaTemperaturaDoCorpo}");
            } else if(animalSelecionado is Ave)
            {
                Console.WriteLine($"O animal encontrado é uma ave com nome {animalSelecionado.Nome} e tem penas = {((Ave)animalSelecionado).TemPena}");
            } else if(animalSelecionado is Peixe)
            {
                Console.WriteLine($"O animal encontrado é um peixe com nome {animalSelecionado.Nome} e tem = {((Peixe)animalSelecionado).QuantidadeNadadeiras} nadadeiras");
            } else 
            {
                Console.WriteLine($"O animal encontrado é um animal com nome {animalSelecionado.Nome}");
            }
        }
    }
}
