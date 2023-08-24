namespace exercicio6
{
    public class DiaDosNamorados : CartaoWeb
    {
        public DiaDosNamorados(string nome = "")
        {
            Destinatario = nome;
        }

        public override void ShowMessage()
        {
            Console.WriteLine($"Feliz Dia dos Namorados, {Destinatario}!");
        }
    }
}
