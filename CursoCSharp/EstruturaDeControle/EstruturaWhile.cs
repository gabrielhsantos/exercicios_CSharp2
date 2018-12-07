using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaWhile {
        public static void Executar() {

            var linhas = "------------------------------------";
            string continuar;
            bool novoJogo = true;

            Console.WriteLine(linhas);
            Console.WriteLine("Bem vindo ao JOGO DE ADIVINHAÇÃO!!!");
            Console.WriteLine("qual o número correto entre 0 e 15 ???");
            Console.WriteLine("OBS: Você tem 5 tentativas");
            Console.WriteLine(linhas);

            while (novoJogo) {
                int palpite = 0;
                Random random = new Random();

                int numeroSecreto = random.Next(1, 16); // intevalo entre 1 e 15, pois o 16 não irá entrar
                bool numeroEncontrado = false;
                int tentativasdRestantes = 5;
                int tentativas = 0;

                // Enquanto o número de tentativas for maior que 0 e o numeroEncontrado for false, execute o While
                while (tentativasdRestantes > 0 && !numeroEncontrado) {

                    Console.Write("Digite seu palpite: ");
                    string entrada = Console.ReadLine();
                    int.TryParse(entrada, out palpite);
                    tentativas++;
                    tentativasdRestantes--;

                    if (numeroSecreto == palpite) {
                        numeroEncontrado = true;
                        var corAnterior = Console.BackgroundColor; //salva a cor atual do background
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Número encontrado em {tentativas} tentativas!!!");
                        Console.BackgroundColor = corAnterior;
                    } else if (tentativasdRestantes == 0 && palpite != numeroSecreto) {
                        Console.WriteLine("INFELIMENTE NÃO FOI DESSA VEZ!!!");
                        Console.WriteLine($"O número secreto era {numeroSecreto}");
                    } else if (palpite > numeroSecreto) {
                        Console.WriteLine("Quase...Tente um número MENOR!");
                    } else if (palpite < numeroSecreto) {
                        Console.WriteLine("Quase...Tente um número MAIOR!");
                    }
                }
                Console.WriteLine(linhas);                

                Console.Write("Deseja Começar novamente? (S/N): ");
                continuar = Console.ReadLine();
                novoJogo = continuar.ToLower() == "s";
                Console.WriteLine(linhas);
            }           
            Console.WriteLine("Obrigado por jogar!!");
            var corAnterior1 = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Até a próxima!!!");
            Console.BackgroundColor = corAnterior1;            
        }
    }
}
