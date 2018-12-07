using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Moto { // internal é padrão para uma classe
        private string Marca; //private irá encapsular para que seja visível apenas dentro da classe (é o padrão).
        private string Modelo;
        private uint Cilindrada; // 3 opção do SetCilindrada

        public Moto(string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() { }

        public string GetMarca() { // Get por padrão tem um tipo pois irá retornar o atributo
            return Marca;
        }

        public void SetMarca(string marca) { // Set por padrão é void
            Marca = marca; // Como o atributo é private, apenas a classe tem acesso, isso cria um "Backdoor"
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
            // 1 Opção
            //if (cilindrada > 0) {
            //    Cilindrada = cilindrada;  //impossibilita um valor negativo
            //} 
            // 2 Opção
            //Cilindrada = Math.Abs(cilindrada); // valor negativo se torna positivo
            // 3 Opção
            Cilindrada = cilindrada;
        }
    }

    class GetSet {
        public static void Executar() {
            Moto moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636); //Instância pelo construtor de parâmetros
            //Console.WriteLine(moto1.Modelo); // Modelo não está mais acessível pelo modo convencional
            Console.WriteLine(moto1.GetModelo()); // Visível apenas pelo Get
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda"); //Instância pelo método Set
            moto2.SetModelo("CG Titan");
            //moto2.SetCilindrada(-150); // "uint" Impossibilita o valor negativo
            moto2.SetCilindrada(150);

            Console.WriteLine($"{moto2.GetModelo()} {moto2.GetModelo()} {moto2.GetCilindrada()}");
        }
    }
}
