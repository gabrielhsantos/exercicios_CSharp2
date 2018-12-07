using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {

    public static class ExtensoesInteiro {


        //Métodos
        public static int Soma(this int num, int outroValorNumerico) { //This associado com o tipo, classifica como extrensão
            return num + outroValorNumerico;
        }        

        public static int Subtracao(this int num, int outroValorNumerico) {
            return num - outroValorNumerico;
        }

        public static double Subtracao(this double num, double outroValorNumerico) {
            return num - outroValorNumerico;
        }
    }

    class MetodosDeExtensao {
        public static void Executar() {
            int numero = 3; //variável comum
            double numeroReal = 3.0;

            Console.WriteLine(numero.Soma(2)); //variável "num" receberá o valor de "numero"
            Console.WriteLine(numero.Subtracao(2));
            Console.WriteLine(numeroReal.Subtracao(2.0));

            //Opção sem variável
            Console.WriteLine(3.Soma(2));
            Console.WriteLine(3.Subtracao(2));
            Console.WriteLine(3.0.Subtracao(2));


        }
    }
}
