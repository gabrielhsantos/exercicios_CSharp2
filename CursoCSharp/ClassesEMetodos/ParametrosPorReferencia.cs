using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {    

        public static void AlterarRef(ref int numero) { //receberá como parâmetro uma referência de um numero inteiro
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero) { // out = apenas saída
            numero = 0; // deve ser inicializado dentro do método
            numero = numero + 15;
        }

        public static void Executar() {

            // o ref é bidirecional, é passado um valor inicial
            int a = 3; // foi passado o valor da variável
            AlterarRef(ref a); // a variável é utilizada como referência para o parâmetro do método
            Console.WriteLine(a); // o valor da variável foi alterado conforme o método em um efeito colateral

            // o out é unidirecional, a variável não pode ser inicializada
            AlterarOut(out int b); // é criada uma variável que receberá a saída do método
            Console.WriteLine(b);
        }
    }
}
