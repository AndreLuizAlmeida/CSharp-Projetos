using System;

namespace EditorDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0: System.Environment.Exit(0);
                    break;
                case 1: Abrir();
                    break;
                case 2: Editar();
                    break;
                default: Menu();
                    break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using (var arquivo = new StreamReader(path))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite o texto abaixo (ESC para sair): ");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
            Salvar(texto);
        }

        static void Salvar(string texto)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho pasa salvar o arquivo? ");
            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(texto);
            }

            Console.WriteLine($"O arquivo {path} foi salvo com sucesso");
            Menu();
        }
    }
}