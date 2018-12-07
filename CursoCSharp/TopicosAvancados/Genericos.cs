using System;
using CursoCSharp.ClassesEMetodos;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {


    public class Caixa<T> { //Tipo genérico T

        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa) { //Construtot com parâmetro do tipo T
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int> { //Na hora da herança, foi definido q o tipo genérico T = int
        public CaixaInt() : base(0) {} //é necessário passar o valor para o construtor de Caixa
    }

    class CaixaProduto : Caixa<Produto> { 
        public CaixaProduto() : base(new Produto()) {} //o construtor precisa ser inicializado
    }

    class Genericos {
        public static void Executar() {

            Console.WriteLine("==== Tipo T irá receber int ====");

            Caixa<int> caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            Console.WriteLine("==== Tipo T irá receber string ====");

            Caixa<string> caixa2 = new Caixa<string>("Gabriel e Ana S2!!!");
            Console.WriteLine(caixa2.metodoGenerico("+ Thominhas!!!"));
            Console.WriteLine(caixa2.Coisa.GetType());

            Console.WriteLine("==== Tipo T irá receber a classe Produto ====");

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
