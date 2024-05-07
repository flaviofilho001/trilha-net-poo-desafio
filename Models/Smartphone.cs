

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Pessoa { get; set; }
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria, string pessoa)
        {
            Numero = numero;

            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            Pessoa = pessoa;
        }

        public void Ligar(string numero, string Pessoa)
        {
            Console.WriteLine($"Ligando para {numero} de {Pessoa}");
        }

        public void ReceberLigacao(string numero, string Pessoa)
        {

            Console.WriteLine($"Recebendo ligação de {numero} de {Pessoa}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}