namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new();
            retangulo.lado1 = 1;
            retangulo.lado2 = 2;
            retangulo.cor = "verde";

            Console.WriteLine(Teste.DetalhesFigura(retangulo));
        }
    }
}






