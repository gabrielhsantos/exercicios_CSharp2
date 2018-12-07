using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano); // :D2 = terá duas casas. Caso coloquem um único digito, ele completa com 0 a esquerda
        }

        public static void Executar() {
            Formatar(mes: 1, dia: 6, ano: 1996); //isso deixará o código mais claro, pois nomeia os parâmetros e não precisa ser em ordem
        }
    }
}
