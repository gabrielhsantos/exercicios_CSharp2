using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {

            var valorNegativo = -5;
            var n1 = 2;
            int n2 = 3;
            bool booleano = true;

            Console.WriteLine(-valorNegativo); // inversão dos sinais
            Console.WriteLine(!booleano); // inverte a operação lógica

            n1++; // operador pós-fixado
            Console.WriteLine(n1);

            --n1; // operador pré-fixado
            Console.WriteLine(n1);

            Console.WriteLine(n1++ == --n2); // Verificação relacional lógica dará TRUE
            Console.WriteLine($"{n1} {n2}"); // são diferentes

            /*
             * EXPLICAÇÂO 
             * n1 no começo = 2
             * ao colocar o -- antes do n2, já reduz automaticamente pra 2
             * isso faz com que a verificação compare 2 e 2, pra depois
             * incrementar o n1 para 3
             * 
             * isso causará um erro de verificação lógica
             * 
             */
        }
    }
}
 