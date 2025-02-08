using System;


namespace Calculadora
{
    class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("---------Calculadora---------");
            Console.WriteLine("(1) - Soma");
            Console.WriteLine("(2) - Subtração");
            Console.WriteLine("(3) - Divisão");
            Console.WriteLine("(4) - Multiplicação");
            Console.WriteLine("(0) - Para Sair\n");
            Console.Write("Qual operação deseja realizar:  ");
            int operacao = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (operacao)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                default:
                    Console.WriteLine("\n--------Calculadora Finalizada--------\n");
                    break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            Console.Write("Digite valor 1:  ");
            double valorOne = double.Parse(Console.ReadLine());
            Console.Write("Digite valor 2:  ");
            double valorTwo = double.Parse(Console.ReadLine());
            double resultado = valorOne + valorTwo;

            Console.WriteLine($"Resultado é:  {resultado}\n");
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.Write("Digite valor 1:  ");
            double valorOne = double.Parse(Console.ReadLine());
            Console.Write("Digite valor 2:  ");
            double valorTwo = double.Parse(Console.ReadLine());
            double resultado = valorOne - valorTwo;

            Console.WriteLine($"Resultado é:  {resultado}\n");
            Menu();
        }

        static void Division()
        {
            Console.Clear();
            Console.Write("Digite valor 1:  ");
            double valorOne = double.Parse(Console.ReadLine());
            Console.Write("Digite valor 2:  ");
            double valorTwo = double.Parse(Console.ReadLine());
            double resultado = valorOne / valorTwo;

            Console.WriteLine($"Resultado é:  {resultado}\n");
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.Write("Digite valor 1:  ");
            double valorOne = double.Parse(Console.ReadLine());
            Console.Write("Digite valor 2:  ");
            double valorTwo = double.Parse(Console.ReadLine());
            double resultado = valorOne * valorTwo;

            Console.WriteLine($"Resultado é:  {resultado}\n");
            Menu();
        }

    }

}

