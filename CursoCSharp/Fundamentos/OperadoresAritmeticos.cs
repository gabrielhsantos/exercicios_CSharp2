using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é: {totalComDesconto}");

            // IMC
            double peso1 = 91.2;
            double altura1 = 1.82;
            double imc1 = peso1 / (altura1 * altura1);
            Console.WriteLine($"O Imc é: {imc1}");

            // Segunda Opção
            double peso2 = 91.2;
            double altura2 = 1.82;
            double imc2 = peso2 / Math.Pow(altura2, 2); // Potenciação, Base = Altura2, Expoente = 2(ao quadrado)
            Console.WriteLine("O Imc é: {0}", imc2);

            // Número Par/Ímpar
            int par = 24;
            var impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
