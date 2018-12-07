using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class AmigoProximo {

        public readonly SubCelebridade amiga = new SubCelebridade();
        // diferente da classe FilhoReconhecido que recebeu por herança,
        // é preciso instanciar para ter acesso aos atributos.

        public void MeusAcessos() {
            Console.WriteLine("Amigo Próximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }
}
