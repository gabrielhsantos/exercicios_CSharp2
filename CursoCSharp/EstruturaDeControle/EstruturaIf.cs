using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIf {
        public static void Executar() {

            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento? (S/N) ");
            entrada = Console.ReadLine();

            // a expreção dentro do parâmetro do IF sempre será booleana verdadeira
            //if (true) {
            //Sentença1;
            //Sentença2;
            //SentençaN;
            //}
            // caso o trecho dentro do parâmetro do IF for verdadeiro, executará a(s) 
            // sentenças dentro do bloco {}

            /*
            if (entrada == "S" || entrada == "s") // sem bloco associado
                bomComportamento = true;
            */

            //bomComportamento = entrada == "S" || entrada == "s"; // pode ser utilizado sem o if acima, já irá considerar como true.
            // OU
            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }

        }
    }
}
