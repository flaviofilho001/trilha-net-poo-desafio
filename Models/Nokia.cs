
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria, string pessoa) : base(numero, modelo, imei, memoria, pessoa)
        {
            this.Numero = numero;
        }

        public override void InstalarAplicativo(string nomeApp)

        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");

        }
    }
}