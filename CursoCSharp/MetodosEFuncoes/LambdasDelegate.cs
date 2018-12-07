using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    //Delegate é definir um tipo que armazena uma assinatura de uma função
    //com isso é possível criar uma variável do tipo do delegate e colocar
    //uma função que respeita a sua assinatura. Pode ser usado tanto dentro, quanto
    //fora de uma classe

    delegate double Operacao(double x, double y);

    class LambdasDelegate {
        public static void Executar() {

            Operacao sum = (x, y) => x + y; //(x, y) ambos serão do tipo double conf delegate
            Operacao sub = (x, y) => x - y;
            Operacao mul = (x, y) => x * y;
            Operacao div = (x, y) => x / y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mul(12, 8));
            Console.WriteLine(div(10, 5));
        }
    }
}
