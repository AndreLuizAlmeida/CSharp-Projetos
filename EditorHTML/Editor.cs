using System;
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
           Console.Clear();
           Console.BackgroundColor = ConsoleColor.White;
           Console.ForegroundColor = ConsoleColor.Black;
           Console.Clear();
           Console.WriteLine("MODO EDITOR");
           Console.WriteLine("-----------");
           Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.End);

            Console.WriteLine("---------");
            Console.WriteLine("Deseja salvar o arquivo?");
        }
    }
}
