using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaForEach {
        public static void Executar() {
            var palavra = "Olá!";

            // o foreach irá percorrer a palavra contando letra por letra até acabar
            foreach (var letra in palavra) {
                Console.Write(letra);
            }
            Console.WriteLine();

            Console.WriteLine("--------- EXERCÍCIO ------------");

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }

            // neste caso, o foreach irá percorrer do primeiro ao último elemento
            
        }
    }
}
