using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // área da circunferência
            double raio = 4.5;
            // exemplo de mudança de variável
            raio = 5.5;
            const double PI = 3.14; //const = constante (não sofrerá alterações)

            double area = PI * raio * raio;
            Console.WriteLine("A Área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo? " + estaChovendo);

            bool estaChovendo2 = false;
            Console.WriteLine("Esta chovendo? " + estaChovendo2);

            // byte só aceita positivos, sbyte aceita negativos
            byte idade = 30;
            Console.WriteLine("Minha idade é " + idade);

            sbyte saldoDeGols = sbyte.MinValue; //-128 (maior = 127)
            Console.WriteLine("Saldo de gols " + saldoDeGols);            

            short salario = short.MaxValue; //32767 (menor = -32768)
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado para inteiros
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("A População Brasileira é de " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            // Ponto Flutuante

            float precoComputador = 1299.99f; //obrigatório o "f" no final
            // se usar o double, utilizará mais memória
            // double armazena mais que o float
            Console.WriteLine("O preço do computador é " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // mais usado para valores reais;
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreAsEstrelas);

            // palavras

            char letra = 'a'; // aspas simples para uma única letra, já aspas duplas é para uma cadeia de letras 
            Console.WriteLine("Letra " + letra);

            string texto = "Curso de C#";
            Console.WriteLine(texto);

        }
    }
}
