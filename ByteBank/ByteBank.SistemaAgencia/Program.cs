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
            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 687876);
            Console.WriteLine(conta);

            object desenvolvedor = new Desenvolvedor("4564654");
            Console.WriteLine(desenvolvedor);

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
    }
}
