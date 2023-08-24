namespace exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Futebol jogo = new();
            Console.WriteLine(jogo.IniciarJogo());
            Console.WriteLine(jogo.FinalizarJogo());
            Console.WriteLine(jogo.ExibirDescricao());
        }
    }
}

