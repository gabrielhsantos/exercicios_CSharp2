using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class UsandoBreak {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número correto é {0}", numero);

            for (int i = 1; i <= 50; i++) {
                Console.Write("{0} é o número correto?", i);
                if (i == numero) {
                    Console.WriteLine("Sim!!");
                    break; // irá interromper o laço for quando o número for o correto
                } else {
                    Console.WriteLine("Não!!");
                }
            }

            Console.WriteLine("Fim!");
        }
    }
}
