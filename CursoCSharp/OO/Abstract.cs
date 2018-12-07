using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    //Classe Abstrata
    public abstract class Celular { //Neste caso abstract não é possível instanciar

        //Método Abstrato
        public abstract string Assistente(); //Métodos Abstratos não possuem corpo

        //Método Concreto
        public string Tocar() {
            return "Trim Trim Trim...!";
        }
    }
    // Uma classe abstrata, pode ter todos os métodos abstratos e/ou concretos.

    // Se a classe tiver métodos abstratos, pode se dizer que ela está inacabada, pois 
    // a classe que implementa-la irá completar com as informações pertinentes.

    // Uma classe abstrata pode herdar de outra também abstrata, no entanto ao passar adiante até
    // que seja concreta, esta irá obrigatoriamente implementar todos os métodos em cadeia.

    public class Samsung : Celular {
        public override string Assistente() {
            return "Assistente Samsung";
        }
    }

    public class IPhone : Celular {
        public override string Assistente() {
            return "Assistente IPhone";
        }
    }

    class Abstract {
        public static void Executar() {
            //Celular c = new Celular(); //Não é possível instanciar classes abstratas

            var celulares = new List<Celular> {
                new IPhone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
