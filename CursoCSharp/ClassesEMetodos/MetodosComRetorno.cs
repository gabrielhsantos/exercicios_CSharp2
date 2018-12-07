using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraComum {

        //Exemplo 1
        public int Somar(double a, int b) {
            return (int)a + b;
        }

        //Exemplo 2
        public int Somar(int a, double b) {
            return a + (int)b;
        }

        //Métodos Utilizados
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    class CalculadoraCadeia {

        int memoria = 0; // com letra minúscula pois é uma variável interna dentro da classe cadeia
                     // int não inicializado recebe como padrão o valor 0;

        public CalculadoraCadeia Somar(int a) {
            memoria += a; // o Método recebe o valor da memória e soma com o valor do parâmetro
            return this; // utilizado para o retorno do tipo CalculadoraCadeia
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int x, int y) {
            memoria = x * y;
            return this;
        }
                
        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    class MetodosComRetorno {
        public static void Executar() {
            // CALCULADORA COMUM //
            Console.WriteLine("-------------------------");
            var calculadoraComum = new CalculadoraComum();

            //Opção 1
            var resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine(resultado);

            //Opção 2
            //Console.WriteLine(calculadoraComum.Somar(5, 5));

            //Console.WriteLine(calculadoraComum.Subtrair(5, 3));
            //Console.WriteLine(calculadoraComum.Multiplicar(3, 5));

            //Console.WriteLine("-------------------------");
            // CALCULADORA CADEIA //
            var calculadoraCadeia = new CalculadoraCadeia();
            //calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar();
            /*
             * EXPLICAÇÃO
             * Após a instância, o método somar é passado, seguido da multiplicação,
             * impressão, zerar e por fim a impressão novamente             * 
             */
            //resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
            // não é possível encadear nada alem de .Resultado() pois o método já é um tipo inteiro
            // assim como o tipo da variável resultado.

            //Teste
            Console.WriteLine("--------Teste---------");
            calculadoraCadeia.Limpar();
            Console.Write("Número: ");
            var entrada1 = Console.ReadLine();
            int.TryParse(entrada1, out int a);

            Console.Write("Número: ");
            var entrada2 = Console.ReadLine();
            int.TryParse(entrada2, out int b);

            var result = new CalculadoraCadeia();

            calculadoraCadeia.Multiplicar(a, b).Resultado();
            Console.WriteLine(calculadoraCadeia.Resultado());
            
            calculadoraCadeia.Somar(a).Somar(b).Resultado();
            Console.WriteLine(calculadoraCadeia.Resultado());
        }
    }
}
