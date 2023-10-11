using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco p = new ContaBanco();

            Console.WriteLine("Deseja Abrir uma conta bancária?");
            p.abrirConta(Console.ReadLine());
            Console.WriteLine(p.getnumConta());
            Console.WriteLine(p.getTipo());
            Console.WriteLine(p.getStatus());
            Console.WriteLine(p.getSaldo().ToString("f2"));
            p.pagarMensal();
            Console.WriteLine(p.getSaldo().ToString("f2"));
            p.sacar();
            Console.WriteLine(p.getSaldo().ToString("f2"));
        }
    }
}
