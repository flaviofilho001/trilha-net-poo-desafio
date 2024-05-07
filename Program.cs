using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Iphone
            Iphone iphone = new Iphone("123456789", "iPhone 12", "ABCDE12345", 128, "Flavio");
            Nokia nokia= new Nokia("83999999999", "Nokia Tijolao", "IMEINOKIA123", 64, "Gabriel");

            // Chamando métodos e propriedades da instância de Iphone
            Console.WriteLine($"Número do iPhone: {iphone.Numero}");
            Console.WriteLine($"Número Nokia: {nokia.Numero}");
            

            // Testando o método InstalarAplicativo
            iphone.InstalarAplicativo("WhatsApp");
            nokia.InstalarAplicativo("Instagram");

            // Testando outros métodos
            iphone.Ligar(nokia.Numero, nokia.Pessoa);
            nokia.ReceberLigacao(iphone.Numero, iphone.Pessoa);
            nokia.Ligar(iphone.Numero, iphone.Pessoa);
            iphone.ReceberLigacao(nokia.Numero, nokia.Pessoa);
            
            
        }
    }
}