using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Calculadora!");

            while (true)
            {
                Console.Write("Digite um número: ");
                double num1 = GetNumberInput();

                Console.Write("Digite um operador (+, -, *, /): ");
                char oper = GetOperatorInput();

                Console.Write("Digite outro número: ");
                double num2 = GetNumberInput();

                double result = PerformOperation(num1, num2, oper);

                Console.WriteLine($"Resultado: {result}");

                Console.Write("Deseja continuar? (S/N): ");
                if (Console.ReadLine().Trim().ToUpper() != "S")
                {
                    break;
                }
            }

            Console.WriteLine("Obrigado por usar a Calculadora!");
        }

        static double GetNumberInput()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double num))
                {
                    return num;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            }
        }

        static char GetOperatorInput()
        {
            while (true)
            {
                char oper = Console.ReadLine().Trim().ToLower()[0];

                if (oper == '+' || oper == '-' || oper == '*' || oper == '/')
                {
                    return oper;
                }
                else
                {
                    Console.WriteLine("Operador inválido. Tente novamente.");
                }
            }
        }

        static double PerformOperation(double num1, double num2, char oper)
        {
            switch (oper)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero. Tente novamente.");
                        return 0;
                    }
                default:
                    return 0;
            }
        }
    }
}