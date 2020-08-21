using System;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        public string URL { get; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            if (url == "")
            {
                throw new ArgumentException("O argumento url não pode ser uma string vazia.", nameof(url));
            }

            URL = url;
        }
    }
}
