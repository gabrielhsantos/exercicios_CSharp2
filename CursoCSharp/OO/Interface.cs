using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    //Interface (Sempre pública e abstrata)
    interface OperacaoBinaria {
        int Operacao(int a, int b); // Sem implementação
        //Em uma interface não é possível colocar o método como abstract
        //pois todos os métodos são abstratos, o mesmo vale para o marcador public.
    }

    interface Teste : OperacaoBinaria { //U,a interface pode implementar outra
        bool SeiLa(string a);
    }

    class Soma : OperacaoBinaria, Teste { // Para duas ou mais mplementações usa-se ,
        public int Operacao(int a, int b) { //Um membro implementado de uma interface é sempre public
            return a + b;
        }

        public bool SeiLa(string podeSerOutroNomeDeParametro) { //Método Implementado
            return true;
        }
    }

    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }

    class Divisao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a / b;
        }
    }

    class Calculadora {

        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
            new Divisao()
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";

            foreach (var operacao in operacoes) { // .GetType().Name = Mostra o nome do tipo 
                resultado += $"Usando a {operacao.GetType().Name} = {operacao.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }


    class Interface {
        public static void Executar() {

            Console.Write("Número: ");
            var entrada1 = Console.ReadLine();
            int.TryParse(entrada1, out int a);

            Console.Write("Número: ");
            var entrada2 = Console.ReadLine();
            int.TryParse(entrada2, out int b);

            Console.WriteLine("---------------");

            Calculadora calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(a, b);
            Console.WriteLine(resultado);
        }
    }
}
