using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaDoWhile {
        public static void Executar() {

            string nome, entrada;
                        
            do {
                Console.Write("Qual o seu nome? ");
                nome = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", nome);
                Console.Write("Deseja continuar com esse usuário? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s"); // única estrutura que termina com ; sem um bloco de código

            /*
             * EXPLICAÇÃO
             * Diferenta da estrutura While, o Do While executa sempre pelo menos uma vez no bloco Do
             * depois faz a verificação lógica no parâmetro do While
             */ 

        }
    }
}
