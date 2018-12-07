using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {

            //Lambda = função anônima

            Action algoNoConsole = () => { //=> notação arrow
                Console.WriteLine("Lambda com C#!");
            };

            /*
             * EXPLICAÇÃO
             * 
             * o Action é o tipo da variável algoNoConsole e é um tipo sem retorno (void)
             * a esta variável está sendo atribuida uma função anônima
             * 
             */

            algoNoConsole(); //chamando a variável como uma função normal


            Action<string> algoNoConsole2 = (a) => { //com parâmetro
                Console.WriteLine("APRENDE DIREITO!" + a);
            };
            algoNoConsole2("!!!");

            Action<string> separacao = (a) => Console.WriteLine("----- {0} -----", a);

            separacao("Jogada de dados");        

            Func<int> jogarDado = () => { //Func tem sempre o return usando o simbolo do generics para informar o tipo
                Random random = new Random();
                return random.Next(1, 7); // de 1 até 6
            };

            Console.WriteLine(jogarDado());

            separacao("Conversor Hexa");

            //Func<int, string> conversorHexa = (numero) => {
            //return numero.ToString("X");
            //};

            //Forma mais curta
            Func<int, string> conversorHexa = numero => numero.ToString("X"); //numero.ToString("X"); converte o número p decimal
            /*
            func = tipo com retorno; 
            <> = parâmetros, irá receber um int e retornar ums string;
            conversorHexa = variável que receberá a função; 
            numero = parâmetro que irá receber nesta função (n precisa colocar o tipo)
            => = notação arrow que serve como um return, ou seja, n precisa de corpo; 
            numero.ToString("X"); =  sentença de código que irá executar quando a função for chamada
            */

            Console.WriteLine(conversorHexa(1234));

            separacao("Formatar data");

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
            string.Format("{0:D2}/{1:D2}/{2}", dia, mes, ano);

            Console.WriteLine(formatarData(1,1,2000));

        }
    }
}
