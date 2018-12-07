using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api {
    class ExemploDateTime {
        public static void Executar() {
            var dateTime = new DateTime(day: 30, month: 3, year: 2019);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //Data Sem Hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Data Com Hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);

            //Acessar a Hora
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minuto: " + diaAtual.Minute);
            Console.WriteLine("Segundo: " + diaAtual.Second);

            //Para Amanhã
            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            //Para Ontem
            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            //Formatando com Flags        
            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("D")); 
            Console.WriteLine(diaAtual.ToString("g")); //Com a Hora
            Console.WriteLine(diaAtual.ToString("G")); //Com a Hora Sem Segundo
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm")); //igual ao "g" 

        }
    }
}
