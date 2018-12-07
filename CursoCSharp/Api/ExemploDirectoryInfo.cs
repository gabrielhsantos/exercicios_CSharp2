using System;
using System.IO;

namespace CursoCSharp.Api {
    class ExemploDirectoryInfo {
        public static void Executar() {
            var dirProjeto = @"~/CursoCSharp/CursoCSharp".ParseHome();
            DirectoryInfo dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }

            Action<string> separacao = (a) => Console.WriteLine($"\n\n======== {a} ==========");

            separacao("Arquivos");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            separacao("Diretórios");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            separacao("Informações");

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Parent.Parent);

        }
    }
}
