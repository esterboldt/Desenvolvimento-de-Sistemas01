using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Verificador de Par ou Ímpar");
        Console.Write("Digite um número inteiro: ");

        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é um número PAR.");
        }
        else
        {
            Console.WriteLine($"{numero} é um número ÍMPAR.");
        }

        Console.ReadLine();
    }
}
