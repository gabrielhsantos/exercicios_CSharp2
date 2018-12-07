using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade {

        // Todos
        public string InfoPublica = "Tenho um instagram!";

        //Herança
        protected string CorDosOlhos = "Verde!";

        //Mesmo projeto(Assembly)
        internal ulong NumeroCelular = 532163516351;

        //Herança ou no mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma classe ou transmitidos por herânça dentro do mesmo projeto (C# >= 7.2)
        private protected string SegredoDeFamilia = "Bla Bla"; //preciso atualizar para 7.2

        //Private = padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica); //public 
            Console.WriteLine(CorDosOlhos); //protected = protegido por herança
            Console.WriteLine(NumeroCelular); //internal = apenas no projeto
            Console.WriteLine(JeitoDeFalar); //protected internal = protegido por herança ou no Projeto
            Console.WriteLine(SegredoDeFamilia); //private protected visto só pela própria classe e classes herdadas
            Console.WriteLine(UsaMuitoPhotoshop); // Unica forma de usar um atributo privado
        }
    }
}
