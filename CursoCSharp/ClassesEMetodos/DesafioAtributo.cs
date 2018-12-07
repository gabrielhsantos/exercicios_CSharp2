using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {

        int a = 10; // atributo private, por padrão, é minúsculo 

        public DesafioAtributo GetA() {
            Console.WriteLine(a); // Método interno que evoca na própria classe um atributo private
            return this;
        }

        public int GetA2() {
            Console.WriteLine(a);
            return a;
        }

        public static void Executar() {
            //Acessar a variável a dentro do método Executar!

            var teste = new DesafioAtributo();
            teste.GetA();
            //ou
            Console.WriteLine(teste.a);
            //ou
            teste.GetA2();
            
            /*
             * EXPLICAÇÃO
             * 
             * Private já é um padrão para atributos
             * ou seja, para acessar o atributo é necessário instanciar um objeto
             * ou criar um método para acessar o valor usando a notação ponto             * 
             * 
             */ 
        }

        // OBS: Métodos estáticos disponibilizam acesso apenas aos atributos do próprio método
        public void Executar2() {

            Console.WriteLine(a);
        }
    }
}
