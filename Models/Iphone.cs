namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"As especificações do seu novo {modelo} são: ");
            Console.WriteLine($"Número do aparelho: {numero}, modelo: {modelo}, IMEI: {imei}, memória: {memoria}");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instale um alicativo");
            Console.WriteLine($"Instalando o aplicativo {nomeApp}...");
            Console.WriteLine($"{nomeApp} instalado com sucesso!");
        }
    }
}