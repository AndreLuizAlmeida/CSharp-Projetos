using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Tela();
        }

        static void Tela()
        {
            Console.WriteLine("----Calculadora----");
            Console.WriteLine("Insira uma opção: ");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("0- Sair");
            String option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Soma();
                    break;
                case "2":
                    Sub();
                    break;
                case "3":
                    Mult();
                    break;
                case "4":
                    Div();
                    break;
                case "0":
                    System.Environment.Exit(0);;
                    break;
                default:
                    Tela();
                    break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("Insira o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor da soma entre {num1} + {num2} é {num1 + num2}");
            Tela();
        }

        static void Sub()
        {
            Console.WriteLine("Insira o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor da subtração entre {num1} + {num2} é {num1 - num2}");
            Tela(); 
        }

        static void Mult()
        {
            Console.WriteLine("Insira o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor da multiplicação entre {num1} x {num2} é {num1 * num2}");
            Tela();
        }

        static void Div()
        {
            Console.WriteLine("Insira o primeiro valor: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor da divisão entre {num1} / {num2} é {num1 / num2}"); 
            Tela();
        }
    }
}