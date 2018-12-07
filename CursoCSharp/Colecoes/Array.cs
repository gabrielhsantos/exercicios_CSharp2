using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] alunos = new string[5]; //estrutura indexada em 5 posições

            alunos[0] = "Thomas";
            alunos[1] = "Ana";
            alunos[2] = "Gabriel";
            alunos[3] = "Bebel";
            alunos[4] = "Dan";
            //alunos[5] = "Teste"; //"Dará erro" índice 5 não existe;

            /*
             * EXPLICAÇÃO
             * 
             * um único identificador (alunos)
             * ira armazenar o valor de 5 posições (string[5]) 
             * 
             * OBS1: o Array é uma estrutura homegênea, 
             * suporta apenas um tipo. Neste caso o string
             * 
             * OBS2: O Array é uma estrutura estática, 
             * ela não cresce ao colocar novos elementos, segue sempre as posições impostas              
             *   
             * OBS3: O Array utiliza índices para a localização  
             *   
             * EXEMPLO:
             * static void Main(string[] args) {}
             * neste caso o método de entrada Main, recebe como parâmetro
             * todo o Array de strings informado em todo código que é guardado dentro da palavra args 
             * 
             * 
             * RESUMINDO -> Array = Homogêneo + Estático + Indexado
             * 
             */

            // Percorrer o array com a opção foreach
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 }; //passando valores direto no índice

            // Percorrer o array com a opção foreach
            foreach (var nota in notas) {
                somatorio += nota;
            }

            // Percorrer o array com a opção for
            //for (int i = 0; i < notas.Length; i++) {
            //   somatorio += notas[i];
            //}

            double media = somatorio / notas.Length; // .Lenght = o tamanho do array
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y'};
            string palavra = new string(letras); 
            Console.WriteLine(palavra);
            // A junção das letras no array é passado em forma de instância e como parâmetro
            // é usado o nome do Array letras.

            char[] letras2 = new char[5];
            letras2[0] = 'A';
            letras2[1] = 'R';
            letras2[2] = 'R';
            letras2[3] = 'A';
            letras2[4] = 'Y';

            string palavra2 = new string(letras2);
            Console.WriteLine(palavra2);
        }
    }
}
