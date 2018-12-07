using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {

    public class Conta {

        double Saldo;
       
        public Conta(double saldo) {
            SetSaldo(saldo);
        }

        public double GetSaldo() { 
            return Saldo;
        }

        public void SetSaldo(double saldo) {
            Saldo = saldo; 
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insuficiênte"); //throw para exceção                
            }
            Saldo -= valor;
        }
    }

    class PrimeiraExcecao {
        public static void Executar() {

            Console.WriteLine("---------------------");
            var saldo = new Conta(1223.45);
            Console.WriteLine($"Seu saldo é de R${saldo.GetSaldo()}");
            Console.WriteLine("---------------------");
            Console.Write("Informe o valor de seu saque: ");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double saque);     

            try {
                saldo.Sacar(saque);
                Console.WriteLine("Retirada com sucesso!");
                Console.WriteLine($"Seu novo saldo é de R${saldo.GetSaldo()}");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message); 
            } finally {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
