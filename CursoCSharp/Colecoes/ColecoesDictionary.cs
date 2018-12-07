using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();
            // o primeiro ítem no genérics é a CHAVE, o segundo é o valor 

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2008));
            }

            /*
             * EXPLICAÇÃO
             * 
             * o Dictionary utiliza o generics para criar uma lista, com um tipo como chave,
             * ao Add na lista, a chave não pode se repetir.
             * 
             * no caso do if, ele vai consultar no Dictionary de nome filmes, se contem a chave 2004
             * se for true, imprime na tela o item da lista filmes puxando pela chave e não pela posição
             * OBS: caso a chave esteja errada, irá causar uma exception
             * 
             * no segundo caso do if, o GetValueOrDefault(), ou ele traz o valor ou não traz nada.
             * Se a chave estiver errada, não irá dar erro no programa e não irá aparecer nada.
             */

            Console.WriteLine(filmes.ContainsValue("Matrix")); // consulta de valor dentro da lista

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}"); // Operador unário + remoção

            filmes.TryGetValue(2006, out string filme2006); // irá tentar localizar pela chave e atribuir o valor à variável do out
            Console.WriteLine($"Filme: {filme2006}!");

            //PERCORRER O DICTIONARY pela chave
            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            //PERCORRER O DICTIONARY pelo valor
            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            //PERCORRER O DICTIONARY pela chave e pelo valor
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            //OU

            //PERCORRER O DICTIONARY pela chave e pelo valor (KeyValuePair<int, string> está Inferido)
            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

        }
    }
}
