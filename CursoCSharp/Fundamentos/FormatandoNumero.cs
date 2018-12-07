using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar(){
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); //o F1 mostra apenas uma casa após a vírgula e arredonda o valor
            Console.WriteLine(valor.ToString("C")); // converte para moeda
            Console.WriteLine(valor.ToString("P")); // Traz o %
            Console.WriteLine(valor.ToString("#.##")); // Seria como o F2

            CultureInfo cultura1 = new CultureInfo("pt-BR");
            CultureInfo cultura2 = new CultureInfo("en-US");

            Console.WriteLine(valor.ToString("C0", cultura1)); //C0 = nenhuma casa decimal, cultura = pt-BR(R$)
            Console.WriteLine(valor.ToString("C0", cultura2)); //C0 = nenhuma casa decimal, cultura = en_US($)

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // completa um número com 10 caracteres com 0 a esquerda 


        }
    }
}
