using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Dependente {
        // string é uma classe
        public string Nome;
        // int é uma struct
        public int Idade;
    }

    class ValorVsReferencia {
        public static void Executar() {
            // Struct = cópia por VALOR!!!
            //Exemplo com int
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");
            //alteração de variável
            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");
            //Exemplo com String
            string palavra = "Bola";
            string copiaPalavra = palavra;
            Console.WriteLine($"{palavra} {copiaPalavra}");
            palavra = "Pipa";
            Console.WriteLine($"{palavra} {copiaPalavra}");

            // Classe = cópia por REFERÊNCIA
            Dependente dep = new Dependente { Nome = "Beto", Idade = 20 };        
            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {dep.Idade}");
            Console.WriteLine($"{copiaDep.Nome} {copiaDep.Idade}");
            //alteração de variável
            copiaDep.Nome = "Gabriel";
            dep.Idade = 30;
            Console.WriteLine($"{dep.Nome} {dep.Idade}");
            Console.WriteLine($"{copiaDep.Nome} {copiaDep.Idade}");
        }
    }
}
