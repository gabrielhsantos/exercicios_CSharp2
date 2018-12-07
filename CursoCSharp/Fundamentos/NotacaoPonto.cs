using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            //Exemplo 1
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            //Exemplo 2
            Console.WriteLine("Teste".Length);

            string valorImportante = null; //dará erro
            Console.WriteLine(valorImportante?.Length); //com o ? o nulo pode ser usado
        }
    }
}
