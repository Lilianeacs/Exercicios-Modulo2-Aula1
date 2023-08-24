namespace exercicio4
{
    public static class Teste
    {
        public static string DetalhesFigura(Figura tipo)
        {
            return $"Cor de figura: {tipo.cor} - Área da figura: {tipo.area()}";
        }           
    }
}
