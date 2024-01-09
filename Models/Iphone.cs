namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
     public Iphone(string numero, string marca,  string imei, int memoria)
            : base(numero, marca, imei, memoria)
        {
        }  


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone...");
        }
    }
}