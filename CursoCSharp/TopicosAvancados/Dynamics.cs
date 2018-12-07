using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Dynamics {
        public static void Executar() {

            dynamic meuObjeto = "teste"; //dinamic é um tipo mais dinâmico, que permite a alteração no decorrer do código
            Console.WriteLine(meuObjeto);
            meuObjeto = 3;
            meuObjeto++;
            Console.WriteLine(meuObjeto);
            meuObjeto = "teste";
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Thomas Henrique dos Santos";
            aluno.idade = 7;
            aluno.nota = 10.0;

            Console.WriteLine($"O aluno {aluno.nome}, de {aluno.idade} anos, tirou nota {aluno.nota}");

        }
    }
}
