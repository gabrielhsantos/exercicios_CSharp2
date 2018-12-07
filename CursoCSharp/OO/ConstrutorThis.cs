using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Animal {
        public string Nome { get; set; }
        public Animal(string nome) {
            Nome = nome;
        }
    }
    public class Cachorro : Animal {
        public double Altura { get; set; }
      
        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"O cachorro {nome} foi instanciado");
        }
        //Se não for especificado um construtor da classe pai, 
        //utiliza-se o construtor base. Neste caso, ele não existe,
        //então deve utilizar a palavra "base" com o parâmetro que 
        //foi recebido como parâmetro.

        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }
        //o " : this()" irá chamar o construtor da própria classe

        public override string ToString() {
            return $"O Cachorro {Nome} têm {Altura}cm de altura!";
        }
        //Método override para transformar o valor recebido em uma string apresentável
    }

    class ConstrutorThis {
        public static void Executar() {
            var spike = new Cachorro("Spike"); //0cm
            var laika = new Cachorro("Laika", 60.0);

            Console.WriteLine(spike);
            Console.WriteLine(laika.ToString()); //Pode ser utilizado desta forma também

        }
    }
}
