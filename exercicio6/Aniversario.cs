namespace exercicio6
{
    public class Aniversario : CartaoWeb
    {
        public Aniversario(string nome = "")
        {
            Destinatario = nome;
        }
        public override void ShowMessage()
        {
            Console.WriteLine($"Feliz Aniversário, {Destinatario}!");
        }
    }
}
