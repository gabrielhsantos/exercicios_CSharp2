using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaFor {
        public static void Executar() {
            Console.WriteLine("-------------- ESTRUTURA WHILE --------------");
            //Estrutura While para um número específico de repetições
            var a = 1;

            while (a <= 10) {
                Console.WriteLine($"Valor de a = {a}.");
                a++;
            }

            Console.WriteLine("-------------- ESTRUTURA FOR --------------");            
            //Estrutura for, exatamente igual a do While            
            for (int b = 1; b <= 10; b++) {
                Console.WriteLine($"Valor de b = {b}.");
            }
            Console.WriteLine("-------------- EXERCÍCIO --------------");

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ",i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            //Operador Ternário
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            /*
             * Se tamanhoTurma for maior que 0, (pois divisão por 0 não tem como)
             * será atribuida a media a divisão de somatorio por tamanhoturma
             * caso contrário será atribuido o valor 0
             */

            Console.WriteLine("A média da turma: {0}", media);
        }
    }
}
