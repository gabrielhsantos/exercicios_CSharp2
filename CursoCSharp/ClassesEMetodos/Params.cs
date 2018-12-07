using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Params {

        //params = conjunto de parâmetros variáveis
        //[] = Array
        //pessoas = o nome do conjunto de parâmetros passados para este método
        public static void Recepcionar(params string[] pessoas) { //pessoas = argumento

            foreach (var pessoa in pessoas) { // pessoa é o nome de atribuição ao Array
                Console.WriteLine("Olá {0}", pessoa);
            }
        }

        public static void Executar() {
            Recepcionar("Thomas", "Ana", "Gabriel");
        }

        /*
         * EXPLICAÇÃO
         * 
         * Foi criado um método com marcador de acesso público, pertencente à classe,
         * sem retorno e de nome Recepcionar, com parâmetro recebendo um array de strings e 
         * nomeando o conjunto de parâmetros como pessoas.
         * 
         * o foreach irá criar uma variável inferenciada como nome pessoa que receberá o conteúdo
         * de cada posição e imprimirá na tela. 
         * Irá percorrer todo o Array pessoas até que todas as posições estejam completas.
         * 
         * Obs: no caso foi passado um parâmetro de strings,
         * ou seja, apenas receberá strings.                   
         * 
         */

    }
}
