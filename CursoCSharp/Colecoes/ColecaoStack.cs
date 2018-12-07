using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecaoStack {
        public static void Executar() {
            var pilha = new Stack(); // O Stack, diferente do Queue, irá contar de tras pra frente

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); //Pop Remove
            // o Pop irá sacar o primeiro elemento da pilha e 
            // vai retornar o objeto que foi removido da lista.

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); //Peek não Remove

            foreach (var item in pilha) {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"Itens na fila: {pilha.Count}");

        }
    }
}
