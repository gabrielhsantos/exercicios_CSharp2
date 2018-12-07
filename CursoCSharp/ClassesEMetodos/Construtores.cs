using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo; // Letras Maiúsculas
        public string Fabricante;
        public int Ano;

        //por padrão, o construtor com parâmetro vazio é assumido quando não criamos um
        //OBS: Ao Criar um construtor com parâmetros, perde-se o construtor padrão
        public Carro(string modelo, string fabricante, int Ano) { //Letras minúsculas
            Modelo = modelo; // O parâmetro recebido no construtor é atribuído ao atributo
            Fabricante = fabricante;
            this.Ano = Ano; // this. informa o objeto atual e não o parâmetro (caso a palavra seja =). 
        }
        public Carro() {}
    }

    class Construtores {
        public static void Executar() {
            //Opção 1 - Construtor com parâmetro vazio
            Carro carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "3251i";
            carro1.Ano = 2017;

            //Opção 2 - Construtor com parâmetro
            var carro2 = new Carro("Ka", "Ford", 2018);

            //Opção 3 - Construtor com parâmetro vazio e bloco de código
            Carro carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };

            Console.WriteLine("{0} {1} {2}", carro1.Fabricante, carro1.Modelo, carro1.Ano);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");
            Console.WriteLine(carro3.Fabricante + " " + carro3.Modelo + " " + carro3.Ano);

        }
    }
}
