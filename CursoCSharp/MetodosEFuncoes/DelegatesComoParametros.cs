using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegatesComoParametros {

        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y) {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y) {
            var resultado = op(x, y);
            return "Resultado: " + resultado;
        }

        public static void Executar() {


            Operacao soma = (int x, int y) => x + y; //com Lambda, criando uma variável
            Console.WriteLine(Calculadora(soma, 8, 2));

            Console.WriteLine(Calculadora(Soma, 8, 2)); //Sem Lambda, utilizando apenas o método

        }
    }
}
