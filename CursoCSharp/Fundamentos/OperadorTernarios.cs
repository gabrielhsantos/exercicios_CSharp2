using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorTernarios {
        public static void Executar() {
            var nota = 7.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";


            /*
             * EXPLICAÇÃO 
             * 
             * Ao atribuir a variável nota o valor 7.0
             * a variável resultado receberá a string referente a operação ternária
             * ou seja: 
             * 1° - caso a nota seja >= 7.0 && bomConportamento seja verdadeiro (Expressão)
             * 2° - atribua a string Aprovado (Operando1)
             * 3° - senão, atribua Reprovado  (Operando2)
             * 
             * o ? indica o operador e o : separa as definições
             * 
             */

            Console.WriteLine(resultado);                  

        }
    }
}
