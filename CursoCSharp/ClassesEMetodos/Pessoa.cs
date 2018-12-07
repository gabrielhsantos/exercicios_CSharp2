using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {

        public string Nome;
        public int Idade;
        //Obs: string tem valo inicial null e int tem valor 0

        public string Apresentar() {
            return string.Format("Olá, me chamo {0} e tenho {1} anos", Nome, Idade);
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}