using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco p = new ContaBanco();

            int opcoes = 0;

            do
            {
                Console.WriteLine("Escolha a ação que deseja realizar: ");
                Console.WriteLine("0 - Abrir conta");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Verificar Saldo bancário atual");
                Console.WriteLine("4 - Verificar o número de sua conta");
                Console.WriteLine("5 - Verificar o o tipo de sua conta");
                Console.WriteLine("6 - Verificar o nome do titular da conta");
                Console.WriteLine("7 - Verificar o status atual da conta");
                Console.WriteLine("8 - Fechar a sua conta");
                Console.WriteLine("9 - Sair do Internet Banking");

                opcoes = int.Parse(Console.ReadLine());

                switch (opcoes)
                {
                    case 0:
                        p.abrirConta(Console.ReadLine());
                        break;
                    case 1:
                        p.depositar();
                        break;
                    case 2:
                        p.sacar();
                        break;
                    case 3:
                        Console.WriteLine(p.getSaldo());
                        break;
                    case 4:
                        Console.WriteLine(p.getnumConta());
                        break;
                    case 5:
                        Console.WriteLine(p.getTipo());
                        break;
                    case 6:
                        Console.WriteLine(p.getDono());
                        break;
                    case 7:
                        Console.WriteLine(p.getStatus());
                        break;
                    case 8:
                        break;
                    case 9:
                        Console.WriteLine("Obrigado por ser cliente.");
                        break;
                }
            }
            while (opcoes != 9);
        }
    }
}


