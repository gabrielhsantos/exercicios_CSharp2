using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            bool executouTrabalho1 = true;
            var executouTrabalho2 = false;

            //OPERADORES BINÁRIOS = possúi dois operandos

            // Operador lógico && (e)
            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTv50);

            // Operador Lógico || (Ou)
            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou Sorvete? {comprouSorvete}");

            // Operador Lógico ^ (xor = ou exclusivo)
            bool comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a TV 32? {0}", comprouTv32);

            //OPERADORES UNÁRIOS = trabalham com apenas um operando

            // Operador de negação lógica ! (não...) -> altera a condição Booleana  
            Console.WriteLine("Mais saudável? {0}", !comprouSorvete); 

        } 
    }
}
