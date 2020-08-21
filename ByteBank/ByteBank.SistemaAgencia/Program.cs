using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaEquals();

            Console.ReadLine();
        }
        
        static void TestaMetodosString()
        {
            string urlTeste = "https://www.bytebank.com/cambio";

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));
            Console.WriteLine(urlTeste.Contains("ByteBank"));
        }

        static void TestaParametrosURL()
        {
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            string moedaOrigem = extrator.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + moedaOrigem);

            string moedaDestino = extrator.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + moedaDestino);

            string valor = extrator.GetValor("VALOR");
            Console.WriteLine("Valor de Valor: " + valor);
        }

        static void TestaRegex()
        {
            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4}[-][0-9]{4}";
            // string padrao = "[0-9]{4,5}[-][0-9]{4}";
            // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            // string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string padrao = @"\d{4,5}-?\d{4}";

            string textoDeTeste = "Meu nome é Guilherme, me ligue em 91234-1234";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
        }

        static void TestaToString()
        {
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 687876);
            Console.WriteLine(conta);

            object desenvolvedor = new Desenvolvedor("4564654");
            Console.WriteLine(desenvolvedor);

            string contaToString = conta.ToString();
            Console.WriteLine("Resultado " + contaToString);
            Console.WriteLine(conta);
        }

        static void TestaEquals()
        {
            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta_2 = new ContaCorrente(1, 1);

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }
        }
    }
}
