using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    sealed class SemFilho { //classe sealed não permite herança
        public double ValorDaFortuna() {
            return 1_300_000_000.00;
        }
    }

    //class SouFilho : SemFilho { }

    class Avo {
        public virtual bool HonrarNomeFamilia() { //Virtual, permite que seja subscrito
            return true;
        }
    }

    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() { //override subscreve e sealed sela e não permite mudança
            return true;
        }
    }

    class FilhoRebelde : Pai {

        //public override bool HonrarNomeFamilia() {  //Método se encontra selado e não pode ser subscrito
        //    return false;            
        //}

        //OUTRA OPÇÃO (ocultação)
        public new bool HonrarNomeFamilia() {
            return false;
        }
    }

    class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia()); //Aparecerá False
        }
    }
}

