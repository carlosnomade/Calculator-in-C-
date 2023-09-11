using System;

namespace Calculator
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

            Console.WriteLine("Qual Serviço deseja utilizar?");

            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divivsão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("----------------");
            Console.WriteLine("Selecione uma opção:");

            short res = short.Parse(Console.ReadLine()!);

            switch (res)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                default: Menu(); break;
            }

        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            float resultado = v1 + v2;

            Console.WriteLine($"O resultado da soma é {resultado}");

            Console.ReadLine();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            float result = v1 - v2;

            Console.WriteLine($"O resultado da subtração é: {result}");

            Console.ReadLine();
            Menu();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine()!);

            float result = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {result}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine()!);

            Console.WriteLine("");

            float result = v1 * v2;

            Console.WriteLine($"O reultado da multiplicação é {result}");

            Console.ReadKey();
            Menu();
        }
    }
}