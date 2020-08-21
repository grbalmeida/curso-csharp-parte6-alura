using Humanizer;
using System;
using System.Globalization;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan trintaSegundos = TimeSpan.FromSeconds(30);
            TimeSpan umaHora = TimeSpan.FromMinutes(60);
            TimeSpan duasHoras = TimeSpan.FromHours(2);

            CultureInfo culture = new CultureInfo("pt-BR");

            string mensagemTrintaSegundos = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(trintaSegundos, 1, culture);
            string mensagemUmaHora = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(umaHora, 1, culture);
            string mensagemDuasHoras = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(duasHoras, 1, culture);

            Console.WriteLine(mensagemTrintaSegundos);
            Console.WriteLine(mensagemUmaHora);
            Console.WriteLine(mensagemDuasHoras);

            Console.ReadLine();
        }
    }
}
