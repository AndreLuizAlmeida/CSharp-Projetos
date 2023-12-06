using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("----Cronometro----");
            Console.WriteLine("S = segundo --> 10s = 10 segundos");
            Console.WriteLine("M = minuto --> 1m = 60 segundos");
            Console.WriteLine("0 - Sair");

            string dados = Console.ReadLine().ToLower();
            if (dados == "0")
            {
                Console.WriteLine("Encerrando programa...");
                System.Environment.Exit(0);
            }
            char tipo = char.Parse(dados.Substring(dados.Length - 1, 1));
            int tempo = int.Parse(dados.Substring(0,dados.Length -1));
            int mult = 1;

            if (tipo == 'm')
            {
                mult = 60;
            }

            if (tempo == 0)
            {
                System.Environment.Exit(0);
            }
            
            Start(tempo*mult);
        }

        static void Start(int tempo)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
        }
    }
}