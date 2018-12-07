using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    class StructVsClasse {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3}; 
            SPonto copiaPonto1 = ponto1; // Atribuição feita por VALOR!!!
            ponto1.X = 3;
            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            Console.WriteLine("Cópia do Ponto 1 X: {0}", copiaPonto1.X);

            /*
             * EXPLICAÇÃO
             * 
             * Instancia de ponto1 com os valores,
             * copia recebeu os valores de ponto1
             * ponto1 mudou o valor de X, mas a cópia não,
             * ela permanesce com o valor estipulado na instância.
             * ou seja, é uma atribuição de valores, pois não ocupa o mesmo lugar na memória
             * 
             */

            CPonto ponto2 = new CPonto { X = 2, Y = 4};
            CPonto copiaPonto2 = ponto2;// Atribuição feita por REFERÊNCIA!!!
            ponto2.X = 4;
            Console.WriteLine("Ponto 2 X: {0}", ponto2.X);
            Console.WriteLine("Cópia do Ponto 2 X: {0}", copiaPonto2.X);

            /*
             * EXPLICAÇÃO
             * 
             * Instancia de ponto2 com os valores,
             * copia recebeu os valores de ponto2
             * ponto2 mudou o valor de X, e a cópia também
             * ou seja, é uma atribuição de referência, pois a cópia ocupa o mesmo lugar na memória
             * 
             */
        }
    }
}
