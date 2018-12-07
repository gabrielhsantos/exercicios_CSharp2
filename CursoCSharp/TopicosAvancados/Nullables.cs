using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Nullables {
        public static void Executar() {

            Nullable<int> num1 = null; //podendo ser reduzido no tipo, como a variável num2
            int? num2 = null; 

            //int teste = null;
            //Console.WriteLine(teste);

            if (num1.HasValue) {
                Console.WriteLine("Valor de num1: {0}", num1);
            } else {
                Console.WriteLine("A variável não possúi valor!!");
            }

            int valor = num1 ?? 1000; //se a variável num1 estiver nula, irá setar o valor 1000 ao int valor
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault(); //Irá obter o valor, ou setar o padrão (false)
            Console.WriteLine(resultado);

            //try {
            //    int x = num1.Value; //Dará erro pois o Value deve estar com a variável setada
            //    int y = num2.Value;
            //    Console.WriteLine( x + y );
            //} catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}

            try {
                int x = num1.GetValueOrDefault(); // valor será = 0
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
