using System;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

 public class Iphone : Smartphone
    {
        // Construtor da classe Iphone que chama o construtor da classe pai Smartphone
        public Iphone(string numero, string modelo, string imei, int memoria, string pessoa) : base(numero, modelo, imei, memoria, pessoa)
        {
            this.Numero = numero;
        
        }

        // Implementa o método abstrato "InstalarAplicativo" da classe pai Smartphone
        public override void InstalarAplicativo(string nomeApp)
        {
            // Lógica para instalar o aplicativo em um iPhone
            Console.WriteLine($"Instalando {nomeApp} no iPhone...");
        }
    }
}