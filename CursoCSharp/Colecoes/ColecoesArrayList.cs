using System;
//using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesArrayList {
        public static void Executar() {
            var arrayList = new ArrayList { //Mudar na biblioteca
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.14);
            Console.WriteLine(arrayList.Count);

            foreach (object item in arrayList) { // Object é um tipo mais genérico
                Console.WriteLine("{0} => {1}", item, item.GetType()); // .GetType() mostra a tipagem 
            }

            Console.WriteLine(arrayList[1]);

            /* 
            *
            * ArrayList pode utilizar quantas posições forem necessárias
            * Pode utilizar qualquer tipagem em qualquer posição
            * 
            * ArrayList = Heterogêneo + Flexível
            * 
            */
        }
    }
}
