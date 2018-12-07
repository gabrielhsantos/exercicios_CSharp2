using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class LINQ2 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() { Nome = "Andre", Idade = 21, Nota = 4.3 },
                new Aluno() { Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() { Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() { Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() { Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() { Nome = "Marcio", Idade = 18, Nota = 6.8 }
            };

            Console.WriteLine("======= Função Single() ========");

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro")); //Caso não haja, cria um Exception
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            /*            
             EXPLICAÇÃO

            uma vez que temos uma lista de nome alunos,
            o .Single() irá retornar apenas um único resultado
            o parâmetro será um Lambda informando que caso a expressão seja verdadeiro,
            irá retornar um único resultado como sendo a variável pedro.

            depois disso é possível chamar pelo objeto o Nome e a Nota
            
             */

            Console.WriteLine("\n======= Função SingleOrDefault() ========");

            var pedroDefault = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("pedro")); //Não existe na lista, retorna NULL               
            if (pedroDefault == null) {
                Console.WriteLine("Aluno Inexistente!!");
            } else {
                Console.WriteLine($"{pedroDefault.Nome} {pedroDefault.Nota}");
            }

            //Na função SingleOrDefault(), caso não encontre a referência na lista, setará a variável como nula

            Console.WriteLine("\n======= Função First() ========");

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"Primeira Ana: {ana.Nome} {ana.Nota}");

            //Na função First(), a variável irá localizar o primeiro valor na lista compatível com a expressão

            Console.WriteLine("\n======= Função FirstOrDefault() ========");

            var anaDefault = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("ana"));
            if (anaDefault == null) {
                Console.WriteLine("Aluno Inexistente!!");
            } else {
                Console.WriteLine($"Primeira Ana: {anaDefault.Nome} {anaDefault.Nota}");
            }

            Console.WriteLine("\n======= Função LastOrDefault() ========");

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            if (outraAna == null) {
                Console.WriteLine("Aluno Inexistente!!");
            } else {
                Console.WriteLine($"Última Ana: {outraAna.Nome} {outraAna.Nota}");
            }

            Console.WriteLine("\n======= Função Skip() e Take() ========");

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var pessoa in exemploSkip) {
                Console.WriteLine(pessoa.Nome);
            }

            // o Skip() informa quantos índices deve pular
            // e o Take() informa quantos índices serão guardados na lista exemploSkip

            Console.WriteLine("\n======= Função Max() e Min() ========");

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            Console.WriteLine("\n======= Função Sum() e Average() ========");//-----------------

            var somaNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somaNotas);

            var mediaNotas = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNotas);

            var mediaNotasAprovados = alunos.Where(aluno => aluno.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNotasAprovados); 
        }
    }
}
