using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class UsandoContinue {
        public static void Executar() {

            //Alternativa "BURRA" de mostrar os números pares
            Console.Write("Digite um número de referência: ");
            string entrada = Console.ReadLine();           
            int.TryParse(entrada, out int intervalo);
            Console.WriteLine();
            Console.WriteLine("Numero pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue; // neste caso o continue irá dar andamento ao laço apenas com a condição no if
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Numero ímpares entre 1 e {0}!", intervalo);
            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 0) {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Numero pares entre 1 e {0}!", intervalo);
            //modo alternativo "+ INTELIGENTE"
            for (int i = 2; i <= intervalo; i += 2) {
                Console.WriteLine(i);
            }
            Console.WriteLine("Numero ímpares entre 1 e {0}!", intervalo);            
            for (int i = 1; i < intervalo; i += 2) {
                Console.WriteLine(i);
            }
        }
    }
}
