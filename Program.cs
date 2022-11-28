using DesafioPOO.Models;

namespace DesafioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia {
                Modelo = "C01 Plus",
                Numero = "(21) 98765-4321",
                IMEI = "355236033030744",
                Memoria = 1
            };

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("-----------------------------------");

            Iphone iphone = new Iphone {
                Modelo = "iPhone 12",
                Numero = "(21) 12345-6789",
                IMEI = "356728113138701",
                Memoria = 64
            };

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("YouTube");
        }
    }
}