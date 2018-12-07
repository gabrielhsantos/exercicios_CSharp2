using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {

            //Modelo FIFO(First In, First Out)

            Queue<string> fila = new Queue<string>(); // Instância da classe Queue

            fila.Enqueue("Thomas"); //Enqueue = Em fila
            fila.Enqueue("Ana");
            fila.Enqueue("Gabriel");
            fila.Enqueue("Gabriel"); // Aceita repetições

            Console.WriteLine(fila.Peek()); // .Peek, pega o próximo elemento que irá sair da fila 
            Console.WriteLine(fila.Count); //Conta os elementos

            Console.WriteLine(fila.Dequeue());  //Desinfilera os restantes e retira o primeiro da fila         
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Peek()); // Irá mostrar o novo topo

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            //curiosidade um Queue usa generics <> e outro não

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue('a');
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item")); // .Contains() = verificação "Se contem"
        }
    }
}
