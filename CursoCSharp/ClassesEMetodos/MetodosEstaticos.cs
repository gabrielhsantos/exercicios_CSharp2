using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraEstatica {

        // Ao colocar a palavra static, significa que este método não pertence mais ao objeto
        // Método de Classe ou método estático
        public static int Somar(int a, int b) { 
            return a + b;
        }

        // Método de instância ou método de objeto
        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    class MetodosEstaticos {
        public static void Executar() {
            //dará erro pois o método não poderá ser acessado como referência de instância. 
            //Console.WriteLine(calculadoraEstatica.Somar(2,2));

            int resultado = CalculadoraEstatica.Somar(2, 2); //sem instância e com retorno int
            Console.WriteLine("Resultado: {0}", resultado);

            //dará erro, pois o método não poderá ser acessado diretamente pelo nome da calculadora
            //Console.WriteLine(CalculadoraEstatica.Multiplicar(2,2));

            CalculadoraEstatica calculadoraEstatica = new CalculadoraEstatica();
            Console.WriteLine(calculadoraEstatica.Multiplicar(2,2));
        }
    }
}
