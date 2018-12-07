using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class CarroOpcional { //classe pública

        double desconto = 0.1; //Atributo privado
        string nome;

        //propriedade manual para o atributo "nome"
        public string Nome { // Este atributo irá armazenar os valores dentro do atributo privado
            get {return "Opcional: " + nome;}
            set {nome = value; } // value irá acessar os valores passados e irá atribuir ao atributo nome
        }
        //propriedades autoimplementada para o atributo "preco"
        public double Preco { get; set; }

        //propriedades somente leitura
        public double PrecoDesconto {
            get => Preco - (desconto * Preco); // Isso é um Lambda
            // get { 
            //      return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome; 
            Preco = preco;
        }
        public CarroOpcional() { }
    }

    class Props {
        public static void Executar() {

            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoDesconto); //neste contexto, está acessando PrecoDesconto como um atributo normal

            //op1.PrecoDesconto = 3000; // Dará erro pois é um atributo somente leitura

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome + "\n" + op1.Preco);
            Console.WriteLine(op2.Nome + "\n" + op2.Preco);
            Console.WriteLine(op2.PrecoDesconto); 

        }
    }
}
