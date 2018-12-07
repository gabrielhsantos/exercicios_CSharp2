using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {

            int inteiro = 10;
            double quebrado = inteiro; // converteu IMPLICITAMENTE um int para double (o inverso não funciona)
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; // converteu EXPLICITAMENTE um double p Int (há perda de informação)
            Console.WriteLine("Nota truncada: {0}", notaTruncada);
            // conversões explícitas são CAST

            Console.Write("Digite Sua Idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            //Caso TryParse não dá erro e converte para "0" caso tenha digitado caracteres
            Console.Write("Digite o primeiro número: ");
            string palavra1 = Console.ReadLine();
            int numero1;
            int.TryParse(palavra1, out numero1); // converta a palavra digitada e jogue em numero
            Console.WriteLine("Resultado: {0}", numero1);

            //Segunda Opção
            Console.Write("Digite o segundo número: ");
            string palavra2 = Console.ReadLine();
            int.TryParse(palavra2, out int numero2); 
            Console.WriteLine("Resultado: {0}", numero2);

            //Terceira Opção
            Console.Write("Digite o terceiro número: ");        
            int.TryParse(Console.ReadLine(), out int numero3);
            Console.WriteLine("Resultado: {0}", numero3);

        }
    }
}
