using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametroPadrao {

        public static int Somar(int a = 1, int b = 2) { // pode passar valores sem ser ref ou out
            return a + b;
        }
        public static void Executar() {

            // 1 Exemplo
            Console.WriteLine(Somar(10,23));

            // 2 Exemplo
            Console.WriteLine(Somar(50)); // entende "a" como 50 e "b" como 2 padrão

            // 3 Exemplo
            Console.WriteLine(Somar()); // 1 + 2 -> já inicializado no método

            // 4 Exemplo
            Console.WriteLine(Somar(b: 7)); // "a" como 1 padrão 
        }
    }
}
