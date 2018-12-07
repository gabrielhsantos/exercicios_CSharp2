using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegateFuncAnonima {

        delegate string StringOperacao(string s);
        delegate void Imprimir(string s);

        public static void Executar() {

            Action<string> separacao = (a) => Console.WriteLine("----- {0} -----", a);


            StringOperacao inverter = delegate (string s) { //O tipo de retorno já definido no tipo da variável
                char[] charArray = s.ToCharArray(); //.ToCharArray(); converte em um array de caracteres
                Array.Reverse(charArray); //.Reverse(); inverte todos os caracteres
                return new String(charArray);
            };

            Console.WriteLine(inverter("I Know Kung Fu!!!"));

            separacao("Teste");

            Console.Write("Digite uma frase e veja ela ao contrario!\nFrase: ");
            string frase = Console.ReadLine();

            Console.WriteLine($"Ao contrário fica: {inverter(frase).ToUpper()}");
        }
    }
}
