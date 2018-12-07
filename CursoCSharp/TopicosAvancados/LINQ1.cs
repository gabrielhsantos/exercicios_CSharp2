using System;
using System.Collections.Generic;
using System.Linq; //Necessário
using System.Text;

namespace CursoCSharp.TopicosAvancados {


    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1 {

        //LINQ = Language Integrated Query (Consulta integrada na linguagem)


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

            Console.WriteLine("===== LISTA DE APROVADOS ======");
            //Filtrando um Array e salvando os dados em outro Array, chamamos de FILTER

            var aprovados = alunos.Where(a => a.Nota >= 7.0).OrderBy(a => a.Nome);
            //var aprovados = alunos.Where(a => true); //Lambda = o aluno será "a" e o método terá sempre o retorno true
            /*
            * EXPLICAÇÃO
            * 
            * já existe uma lista "alunos"
            * a variável "aprovados" irá se tornar uma nova lista puxando do "alunos"
            * a condição que estiver dentro do .Where() = Filter
            * 
            */
            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n\n===== CHAMADA ======");
            //Transformando uma lista de objetos em uma lista de string com apenas o nome do aluno
            //Transformando um Array em outro Array, modificando algo, chamamos a função de MAP

            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome); //OrderBy() = Ordena / Select() = seleciona apenas o atributo
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno); // Não é preciso colocar o .Nome pois é a unica coisa salva na lista
            }

            Console.WriteLine("\n\n===== LISTA DE APROVADOS (por idade)======");
            //Muito Parecido com SQL

            var alunosAprovados = from aluno in alunos
                                  where aluno.Nota >= 7
                                  orderby aluno.Idade
                                  select aluno.Nome;

            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
        }
    }
}
