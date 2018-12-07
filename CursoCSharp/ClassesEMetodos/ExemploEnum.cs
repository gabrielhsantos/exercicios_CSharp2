using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public enum Genero {
        ACAO,
        AVENTURA,
        TERROR,
        ANIMACAO,
        COMEDIA
    };
    // enum trabalha com índices, neste caso são 5 índices (do 0 ao 4)
    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme; //O tipo é a classe enum
    }

    class ExemploEnum {
        public static void Executar() {
            //Primeira forma de converter um enum para um inteiro
            int id = (int)Genero.ANIMACAO; // atribui à variável id, a posição do índice
            Console.WriteLine(id);
            // a variável id irá receber o valor correspondente ao índice de Animação = 3

            // Segundo exemplo usando o enum para identificação
            Filme filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.COMEDIA;
            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);

            //Ou
            Filme filmeParaFamilia2 = new Filme {
                Titulo = "Matrix",
                GeneroDoFilme = Genero.ACAO
            };
            Console.WriteLine("{0} é {1}!", filmeParaFamilia2.Titulo, filmeParaFamilia2.GeneroDoFilme);

        }
    }
}
