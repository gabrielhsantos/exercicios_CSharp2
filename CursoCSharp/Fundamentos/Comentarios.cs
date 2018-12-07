using System;

namespace CursoCSharp.Fundamentos {
    /// <summary>
    /// 
    /// </summary>
    class Comentarios {
        public static void Executar(){
            // evitar comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");

            Console.WriteLine("o C# tem o XML Comments.");
            // Exemplo: 3 barras antes do Método, criará um sumário

            Console.WriteLine("Comentário de Múltiplas linhas também é possível.");           
            /*
             * Como neste exemplo
             * o comentário
             * possúi muitas linhas
             */

            //DICA: ao selecionar uma ou mais linhas, utilizar as teclas Ctrl+K+C comenta
            //e Ctrl+K+U decomenta trechos de código
        
        }
    }
}
