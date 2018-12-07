using System;
using Encapsulamento;


namespace CursoCSharp.OO {

    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho não reconhecido...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amigoDistante = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Distante...");

            Console.WriteLine(amigoDistante.InfoPublica);
            //Console.WriteLine(amigoDistante.CorDosOlhos);
            //Console.WriteLine(amigoDistante.NumeroCelular);
            //Console.WriteLine(amigoDistante.JeitoDeFalar);
            //Console.WriteLine(amigoDistante.SegredoDeFamilia);
            //Console.WriteLine(amigoDistante.UsaMuitoPhotoshop);           

        }
    }

    class Encapsulamento {
        public static void Executar() {

            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            //Ao invés de instanciar um objeto, para depois chamar um método pelo objeto
            Console.WriteLine("_________________________");
            new SubCelebridade().MeusAcessos();
            Console.WriteLine("_________________________");
            new FilhoReconhecido().MeusAcessos();
            Console.WriteLine("_________________________");
            new AmigoProximo().MeusAcessos();
            Console.WriteLine("_________________________");
            new FilhoNaoReconhecido().MeusAcessos();
            Console.WriteLine("_________________________");
            new AmigoDistante().MeusAcessos();
            Console.WriteLine("_________________________");




        }
    }
}
