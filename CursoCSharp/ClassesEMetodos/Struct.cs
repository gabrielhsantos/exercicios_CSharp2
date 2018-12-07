using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    interface Ponto { //Interface é uma função sem corpo
        void MoverNaDiagonal(int delta); // simplesmente colocando o parâmetro
    }
    // Interface é publico por padrão e não pode ser private

    struct Coordenada : Ponto { //: referencia uma interface e caso isso ocorra, é preciso implementar cada método da interface
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }
        // Implementação da interface obrigatória
        public void MoverNaDiagonal(int delta) {
            X = X + delta;
            Y += delta;
        }
    }

    class ExemploStruct { // O nome do arquivo continua como Struct, para demonstrar que não há esse tipo de amarração em C#
        public static void Executar() {
            Coordenada coordenadaInicial; // não foi preciso uma instância
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;
            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            Coordenada coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);
            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);

            /*
             * EXPLICAÇÃO 
             * foi criada uma variável do tipo Coordenada(struct), e não foi preciso instancia-la
             * as variáveis dentro da classe são public, ou seja, não é preciso Get e Set
             * a variável do tipo cordenada deu os valores para as variáveis da classe
             * depois foi evocado os valores
             * 
             * na segunda etapa, foi criada uma segunda variável, inicializada pelo construtor
             * setando os valores para os parâmetros do construtor
             * depois a variável foi referenciada pela implementação da interface dentro do struct
             * mudando a variável delta do valor 0 para 10
             * depois foi evocado os valores respectivos de X e Y             
             */ 
        }
    }
}
