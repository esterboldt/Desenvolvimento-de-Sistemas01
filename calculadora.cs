using System;

class Program
{
    static void Main()
    {
        double num1, num2, resultado;
        char operador;

        Console.WriteLine("Calculadora Simples em C#\n");

        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o operador (+, -, *, /): ");
        operador = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                break;
            case '-':
                resultado = num1 - num2;
                Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                break;
            case '*':
                resultado = num1 * num2;
                Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                break;
            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;
            default:
                Console.WriteLine("Operador inválido.");
                break;
        }

        Console.ReadLine();
    }
}
