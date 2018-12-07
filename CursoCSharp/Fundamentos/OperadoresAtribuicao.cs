using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3; // variável inferida

            num1 = 7; // a variável num1 está sendo substituída pelo valor 7

            num1 += 10; // num1 = num1 + 10
            num1 -= 3; // num1 = num1 - 3
            num1 *= 5; // num1 = num1 * 5
            num1 /= 2; // num1 = num1 / 2

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            //Operador unário de incremento e decremento
            a++; // a = a + 1
            b--; // b = b - 1

            Console.WriteLine($"{a} {b}");

            //Código como exemplo
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);

            /*EXPLICAÇÃO
             * 
             * no exemplo a e b, o b foi uma cópa de a,
             * mas não foi alocado no mesmo espaço de memória, é  independênte
             * 
             * no c e d, ambos foram alocados no mesmo espaço, ou seja, ao alterar
             * um, o outro também será alterado.
             * 
             */ 

            
        }
    }
}
