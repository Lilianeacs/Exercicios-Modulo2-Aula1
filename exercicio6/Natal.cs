namespace exercicio6
{
    public class Natal : CartaoWeb
    {
        public Natal(string nome = "")
        {
            Destinatario = nome;
        }

        public override void ShowMessage()
        {
            Console.WriteLine($"Feliz Natal, {Destinatario}!");
        }
    }
}
