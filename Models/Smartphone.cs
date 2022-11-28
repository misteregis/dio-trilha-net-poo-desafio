using System.Text.RegularExpressions;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string modelo = string.Empty;
        private string Fabricante { get; set; }
        public string Numero { get; set; }
        public string Modelo {
            get => this.modelo;
            set {
                string fabricante = this.GetType().Name;

                if (fabricante == "Iphone")
                    fabricante = "Apple";

                this.modelo = $"{fabricante} {value}";
            }
        }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone() {}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            WriteColor($"[{Modelo}]: Ligando...", ConsoleColor.Yellow);
        }

        public void ReceberLigacao()
        {
            WriteColor($"[{Modelo}]: Recebendo ligação...", ConsoleColor.Yellow);
        }

        public abstract void InstalarAplicativo(string nomeApp);

        /// <summary>
        /// Método criado para escrever na tela o texto colorido.
        /// </summary>
        /// <example>Exemplo de uso:
        /// <code>
        /// WriteColor(
        ///     mensagem: "[Este] é [apenas] um [teste]...",
        ///     corPadrao: ConsoleColor.DarkGreen,
        ///     cores: new ConsoleColor[]{
        ///         ConsoleColor.Red,
        ///         ConsoleColor.Yellow,
        ///         ConsoleColor.Magenta
        ///     }
        /// );
        /// </code>
        /// </example>
        /// <param name="mensagem">A mensagem que será impressa.</param>
        /// <param name="corPadrao">A cor do texto em geral.</param>
        /// <param name="cores">Uma lista de cores para cada texto entre colchetes.</param>
        /// <param name="quebrarLinha">Falso para não quebrar a linha.</param>
        protected void WriteColor(string mensagem = "", ConsoleColor corPadrao = default, ConsoleColor[] cores = null, bool quebrarLinha = true)
        {
            int indice = 0;

            string[] partes = Regex.Split(mensagem, @"(\[[^\]]*\])");

            Console.ForegroundColor = corPadrao;

            for (int i = 0; i < partes.Length; i++)
            {
                string parte = partes[i];

                if (parte.StartsWith("[") && parte.EndsWith("]"))
                {
                    if (cores != null) {
                        if (indice < cores.Length)
                            Console.ForegroundColor = cores[indice];
                        else
                            Console.ForegroundColor = cores[0];
                    }

                    parte = parte.Substring(1, parte.Length - 2);
                    indice++;
                }

                Console.Write(parte);
                Console.ForegroundColor = corPadrao;
            }

            if (quebrarLinha)
                Console.WriteLine();
        }
    }
}