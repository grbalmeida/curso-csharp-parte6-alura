using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(458, 455789);

            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
