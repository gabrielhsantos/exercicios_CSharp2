using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            //double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0 || nota < 0.0); // || = "e"
            Console.WriteLine("Nota perfeita? {0}", nota == 10.0); // == igualdade
            Console.WriteLine($"Tem como melhorar? {nota != 10.0}"); // != diferente
            Console.WriteLine("Passou por média? {0}", nota >= notaCorte);
            Console.WriteLine($"Recuperação? {nota < notaCorte}");
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
