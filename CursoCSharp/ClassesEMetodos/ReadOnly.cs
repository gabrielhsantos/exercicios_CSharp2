using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome; // Pelo fato de ser public, não é preciso fazer o get e set
        //const DateTime Nascimento; //dará erro, pois DateTime não pode ser uma constante
        readonly DateTime nascimento; // atributo private + read only
        //readonly faz o atributo ser imutável e é possível setar o valor dentro do construtor

        //construtor
        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            this.nascimento = nascimento;
        }

        //método
        public string GetDataDeNascimento() {
            return string.Format("{0:D2}/{1:D2}/{2}", nascimento.Day, nascimento.Month, nascimento.Year);
        }
    }

    class ReadOnly {
        public static void Executar() {
            //instância
            Cliente novoCliente = new Cliente("Gabriel", new DateTime(1988, 7, 5)); //na instância do DateTime fica como ANO, MÊS, DIA
            Console.WriteLine($"Nome: {novoCliente.Nome}, Data de Nascimento: {novoCliente.GetDataDeNascimento()}");
            // O GetDataDeNascimento() irá evocar o atributo private já com o formato de DIA, MÊS, ANO
        }
    }
}
