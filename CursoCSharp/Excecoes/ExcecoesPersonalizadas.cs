using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {

    public class NegativoException : Exception {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception {
        public ImparException(string message) : base(message) { }
    }

    class ExcecoesPersonalizadas {



        public static string PositivoPar() {
            Random random = new Random();
            int valor = random.Next(-30, 31);

            if (valor < 0) {
                throw new NegativoException($"O Valor {valor} é um Número Negativo!!");
            } 
            if (valor % 2 == 1) {
                throw new ImparException($"O Valor {valor} é um Número Ímpar!!");
            }

            return $"O Valor {valor} é Positivo e Par!!";
        }

        public static void Executar() {
            try {
                Console.WriteLine(PositivoPar());
            } catch (NegativoException ex) {
                Console.WriteLine(ex.Message);
            } catch (ImparException ex) {
                Console.WriteLine(ex.Message);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Final");
            }
        }
    }
}
