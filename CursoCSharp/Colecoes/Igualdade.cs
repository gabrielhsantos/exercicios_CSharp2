using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2); // Operador unário
            // dará False, pois esta verificação é por espaço de memória e não por valor
            Console.WriteLine(p3 == p2);
            // dará True, pois esta verificação é por referência

            Console.WriteLine(p1.Equals(p2)); // .Equals() método de verificação de igualdade de endereço de memória (==)


            /*
             * EXPLICAÇÃO
             * 
             * na classe Produto, foi criado um método "override" com parâmetro de uma variavel do tipo objeto,
             * depois foi criado uma variável do tipo Produto que recebe como valor o obj também do tipo Produto
             * na sequencia, há a verificação lógica se o valor de Nome é igual ao valor do objeto outroProduto
             * e verificação do Preço.
             * no retorno do método, trará um resultado booleano se o nome e o preço forem iguais(valor) ao atributo.              
             
                CÓPIA DO PRIMEIRO MÉTODO EQUALS()

                public override bool Equals(object obj) {
                Produto outroProduto = (Produto)obj;
                bool mesmoNome = Nome == outroProduto.Nome;
                bool mesmoPreco = Preco == outroProduto.Preco;

                return mesmoNome && mesmoPreco;             
                }

             * O GetHashCode() deve ser implementado junto com o Equals,
             * pois ele irá primeiro filtrar os itens com o mesmo Hash (identificador)
             * para só então fazer a verificação. Isso agiliza o processo do Equals()
             * No caso do método, irá retornar por tamanho dos caracteres nos valores de Nome                           

                CÓPIA DO SEGUNDO MÉTODO GETHASHCODE()

                public override int GetHashCode() {
                return Nome.Length;
                }

             */
        }
    }
}
