using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class UsandoDelegate {


        delegate double Soma(double a, double b);
        delegate void ImprimeSoma(double a, double b);
       
        static double MinhaSoma(double a, double b) {            
            return a + b;
        }

        static void ImprimirMinhaSoma(double a, double b) {
            Console.WriteLine(a + b);
        }

        public static void Executar() {

            Soma op1 = MinhaSoma; //a função foi associada à variável op1 do tipo Soma(delegate)
            Console.WriteLine(op1(2, 3));

            ImprimeSoma op2 = ImprimirMinhaSoma;
            op2(5, 8.3);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2, 3));

            Action<double, double> op4 = ImprimirMinhaSoma;
            op4(1.3, 5);

        }
    }
}
