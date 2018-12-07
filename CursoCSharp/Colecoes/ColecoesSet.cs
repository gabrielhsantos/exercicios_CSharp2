using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    class ColecoesSet {
        public static void Executar() {

            HashSet<Produto> carrinho = new HashSet<Produto>();

            Produto livro = new Produto("Game of Thrones", 49.9);
            carrinho.Add(livro);

            HashSet<Produto> combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("DVD", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10) // Equals e GetHashCode implementados
            };

            carrinho.UnionWith(combo); // União da lista carrinho com a lista combo       
            Console.WriteLine(carrinho.Count); 
            //carrinho.RemoveAt(3);           

            foreach (var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"- {item.Nome} R${item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); // Como o objeto livro já foi add no SET, ele não será add novamente
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine("O último índice real de livro é {0}", carrinho.LastIndexOf(livro));

            //Estrutura SET não é indexada e não aceita repetições de objetos

        }
    }
}
