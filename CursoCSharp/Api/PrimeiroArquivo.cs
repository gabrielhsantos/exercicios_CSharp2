using System;
using System.IO; //Definição de classe para uso de arquivo

namespace CursoCSharp.Api {


    public static class ExtensaoString {


        public static string ParseHome(this string path) {
            //string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
            //    Environment.OSVersion.Platform == PlatformID.MacOSX)
            //    ? Environment.GetEnvironmentVariable("HOME")
            //    : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            //return path.Replace("~", home);
            return path.Replace("~", "D:/TI/UDEMY/LINGUAGENS/C#/C# CURSO COMPLETO DO BASICO AO AVANÇADO/EXERCICIOS/exercicios_CSharp2");
        }
    }

    class PrimeiroArquivo {
        public static void Executar() {
            // Para o Visual Studio, o "\" serve como indicação de execução para algumas funções.
            // EX: \n = pula linha; \t = Tab.
            //Ao usar o @ antes da string, irá ser considerado não como caracteres especiais, e sim como literiais
            //Após o @, usa-se o "~" para identificar a pasta home do usuário 

            var path = @"~/Primeiro_arquivo.txt";
            //D:/TI/UDEMY/LINGUAGENS/C#/C# CURSO COMPLETO DO BASICO AO AVANÇADO/EXERCICIOS

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("--------");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais");
                sw.WriteLine("texto!");
            }
        }
    }
}
