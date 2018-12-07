using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Gabriel";
            // o próprio C# reconhece por exemplo que ao colocar algo dentro de uma cadeia de
            // caracteres, está dizendo que é um tipo String
            // Inferência é quando o "var" associa ao tipo correto.
            Console.WriteLine("Nome: " + nome);

            var idade = 30; // variáveis de tipo implícito devem ser inicializadas
            Console.WriteLine("Idade: " + idade);

            int a;
            a = 1;

            int b = 2;

            var soma = a + b;

            Console.WriteLine("Soma de " + a + " e "+ b + " = " + soma);

        }
    }
}
