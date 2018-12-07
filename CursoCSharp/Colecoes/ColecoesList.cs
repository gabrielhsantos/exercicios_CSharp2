using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    public class Produto {

        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            var produto = obj as Produto;
            return produto != null &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            var hashCode = -347481536;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            return hashCode;
        }

        ////Exercício da classe igualdade
        //public override bool Equals(object obj) { // Override, pois o método já existe 
        //    Produto outroProduto = (Produto)obj;
        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco == outroProduto.Preco;
        //    return mesmoNome && mesmoPreco;
        //}

        //public override int GetHashCode() {
        //    return Nome.Length;
        //}
    }

    class ColecoesList {
        public static void Executar() {

            List<Produto> carrinho = new List<Produto>(); // <> = Generics -> escolha do dito de dados que a lista irá armazenar

            Produto livro = new Produto("Game of Thrones", 49.9);
            carrinho.Add(livro); // item adicionado na lista

            List<Produto> combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("DVD", 99.9),
                new Produto("Poster", 10)                
            };

            carrinho.AddRange(combo); //Todos os elementos da lista combo serão adicionados na lista carrinho           

            Console.WriteLine(carrinho.Count); //irá fazer a contagem dos elementos da lista
            carrinho.RemoveAt(3); // irá deletar da lista o elemento da posição 3 (Poster)
            Console.WriteLine(carrinho.Count);

            carrinho.Add(livro); //List é uma estrutura que aceita repetição de valores
            Console.WriteLine("O último índice real de livro é {0}", carrinho.LastIndexOf(livro));

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item)); // irá colocar o número do índice
                Console.WriteLine($"- {item.Nome} R${item.Preco}");
            }
            
            /*
             * EXPLICAÇÃO
             * 
             * Diferente do Array, os índices são ilimitados 
             * e o tipo dos valores podem ser classes
             * 
             * O ideal é ter listas homogêneas, para que não haja confusão na hora
             * de evocar um determinado dado.
             * 
             * RESUMINDO -> List = Homo/Hetero + Ilimitado + Indexado                        
             * 
             */
        }
    }
}
