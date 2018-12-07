using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Carro {
        //Protected = protegido por herança; readonly = não será variável
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual; //Privado

        //Contrutores
        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        //Métodos
        protected int AlterarVelocidade(int x) {
            int novaVelocidade = VelocidadeAtual + x;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        //Modificador de acesso virtual = permite que o método seja subscrito
        public virtual int Acelerar() {
            Console.Write("O Carro acelerou para: ");
            return AlterarVelocidade(5);
        }

        public int Frear() {
            Console.Write("O Carro diminuiu para: ");
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro {     
        // Necessário criar um construtor que chame a base da classe pai, pois na classe pai n existe um const padrão
        public Uno() : base(200) { // 200 = VelocidadeMaxima             
        }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(350) {
        }

        //override = muda uma determinada função definida pela classe pai
        public override int Acelerar() {
            Console.Write("O Carro acelerou para: ");
            return AlterarVelocidade(15);
        }

        //Oculta o método da classe pai
        public new int Frear() {
            Console.Write("O Carro diminuiu para: ");
            return AlterarVelocidade(-15);
        }
    }

    class Heranca {
        public static void Executar() {

            List<Carro> carro = new List<Carro> {
                new Uno(),
                new Ferrari()
            };












            Console.WriteLine("_______________________________\nUNO:");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar()); //Método recebido por herança
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear()); //Método recebido por herança            
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("_______________________________\nFerrari:");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar()); //Método override
            Console.WriteLine(carro2.Acelerar()); 
            Console.WriteLine(carro2.Frear()); //Método new
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());

            Console.WriteLine("_______________________________\nFerrari com tipo específico Carro:");
            Carro carro3 = new Ferrari(); //Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("_______________________________\nUno com tipo específico Carro:");
            carro3 = new Uno(); //Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());     
            
            //OBS: no polimorfismo é utilizado o método do tipo e não da instência.
        }
    }
}
