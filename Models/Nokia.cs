namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia() {}

        // public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}
        public Nokia(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            WriteColor(
                mensagem: $"Instalando [\"{nomeApp}\"] no [{Modelo}]...",
                corPadrao: ConsoleColor.DarkGreen,
                cores: new ConsoleColor[]{
                    ConsoleColor.Red,
                    ConsoleColor.Blue
                }
            );
        }
    }
}