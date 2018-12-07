using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Comida {

        internal string Nome;

        public double Peso;

        public Comida(string nome, double peso) {
            Nome = nome;
            Peso = peso;
        }
        public Comida() { }
    }

    //CLASSES
    public class Feijao : Comida {
        public Feijao(string nome, double peso) : base(nome, peso) { }
    }
    public class Arroz : Comida { }
    public class Carne : Comida { }

    public class Pessoa {

        public double Peso;

        public Pessoa(double peso) {
            Peso = peso;
        }

        //MÉTODOS
        //public void Comer(Feijao feijao) {
        //    Peso = Peso + feijao.Peso;
        //}

        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne) {
        //    Peso = Peso + carne.Peso;
        //}

        public void Comer(Comida comida) { //Transformou polimorficamente todos os métodos em um só
            Peso = Peso + comida.Peso;
        }
    }

    class Polimorfismo {
        public static void Executar() {


            List<Comida> comidas = new List<Comida> {
                new Feijao("Feijão", 0.3),
                new Arroz { Nome = "Arroz", Peso = 0.25 },
                new Carne{ Nome = "Carne", Peso = 0.3 }
            };

            foreach (var comida in comidas) {
                Console.WriteLine($"O Peso do {comida.Nome.ToUpper().ToString()} é de {comida.Peso.ToString()}Kg");
            }

            Pessoa cliente = new Pessoa(80.2);
            Console.WriteLine($"O peso inicial do cliente é {cliente.Peso}Kg!!");

            foreach (var comida in comidas) {
                cliente.Comer(comida);
            }
            Console.WriteLine($"O peso final do cliente é {cliente.Peso}Kg!!");


            //Feijao ingrediente1 = new Feijao(0.3);           

            //Arroz ingrediente2 = new Arroz();
            //ingrediente2.Peso = 0.25;

            //Carne ingrediente3 = new Carne();
            //ingrediente3.Peso = 0.3;


            //Pessoa cliente = new Pessoa(80.2);
            //Console.WriteLine($"O peso inicial do cliente é {cliente.Peso}Kg!!");
            //cliente.Comer(ingrediente1);
            //cliente.Comer(ingrediente2);
            //cliente.Comer(ingrediente3);           

            //Console.WriteLine($"O peso final do cliente é {cliente.Peso}Kg!!");
        }
    }
}
