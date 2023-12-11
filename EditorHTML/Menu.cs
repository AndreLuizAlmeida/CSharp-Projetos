using System;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Heelo");
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            Console.Write("+");
            for (int i = 0; i < 30; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3,2); 
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3,8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3,11);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Editor.Show(); break;
                case 2:
                    Console.WriteLine("Abrir"); break;
                case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default:
                    Show(); break;    
                
            }
        }
    }
}