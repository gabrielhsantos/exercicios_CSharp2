using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {

        public static void Executar() {

            string entrada;

            Pessoa filho = new Pessoa();
            Console.Write("Qual o nome do seu primeiro filho? ");
            filho.Nome = Console.ReadLine();
            Console.Write($"Qual a idade do {filho.Nome}? ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out filho.Idade);

            //if (filho.Idade == 0) {
            //    Console.WriteLine("Nooosssa, que petenino!!");
            //} else if (filho.Idade > 0 && filho.Idade <= 5) {
            //    Console.WriteLine("Nosssa, como o tempo voa!!!");
            //} else {
            //    Console.WriteLine("Já é um nimino Gaaande!!");
            //}

            //Console.WriteLine($"{filho.Nome} tem {filho.Idade} anos.");

            Console.WriteLine(filho.Apresentar()); //opção 1

            filho.ApresentarNoConsole(); // opção 2
           
            var apresentacaoDoFilho = filho.Apresentar(); // opção 3

        }        
    }
}
