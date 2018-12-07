using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1; //Static faz com que se torne um atributo de classe e não mais de instância

        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() {}

        public double CalcularDesconto() {
            return Preco - (Preco * Desconto);
        }
    }

    class AtributosEstaticos {
        public static void Executar() {

            Produto produto1 = new Produto("Caneta", 3.2, 0.5); // usando o construtor

            Produto produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3,
                //Desconto = 0.3 // dará erro pois não é possível alterar um atributo de classe (static)
           };

            Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.5; //TODOS os produtos terão o mesmo desconto
            // Através de um método de instância, é possível acessar um atributo de classe
            // OBS: o método deve pertencer a mesma classe do atributo em questão            
        }
    }
}
