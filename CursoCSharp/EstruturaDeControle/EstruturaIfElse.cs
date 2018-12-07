using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIfElse {
        public static void Executar() {

            string nome, entrada;                                

            Console.Write("Digite o nome do Aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota1);
            Console.Write("Digite a segunda nota: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota2);
            Console.Write("Digite a terceira nota: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota3);
            Console.Write("Digite a quarta nota: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota4);

            Console.Write($"O Aluno {nome} está ");
            if (nota1 + nota2 + nota3 + nota4 >= 7.0) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que a sua obrigação!!!");
            } else {
                Console.WriteLine("de Recuperação!");
            } 

        }
    }
}
