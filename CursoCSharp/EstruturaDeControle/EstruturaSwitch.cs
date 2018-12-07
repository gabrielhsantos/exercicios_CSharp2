using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaSwitch {
        public static void Executar() {
            Console.Write("Avalie o atendimento com uma nota de 0 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssima!");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim!");
                    break;
                case 3:
                    Console.WriteLine("Regular!");
                    break;
                case 4:
                    Console.WriteLine("Boa!");
                    break;
                case 5:
                    Console.WriteLine("Ótima!");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }                      
            
            Console.WriteLine("Obrigado pela resposta!");
            
        }
    }
}
