using System;

class Program
{
    static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            Console.Clear();

            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1. Strogonoff");
            Console.WriteLine("2. Macarrão");
            Console.WriteLine("3. Executivo");
            Console.WriteLine("4. Sair");

            Console.Write("\nDigite o número da opção desejada: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("\nVocê escolheu Strogonoff.");
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("\nVocê escolheu Macarrão.");
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("\nVocê escolheu Executivo.");
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("\nSaindo do programa...");
                    sair = true; 
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }

        Console.WriteLine("\nFim do programa. Pressione qualquer tecla para fechar...");
        Console.ReadKey();
    }
}
