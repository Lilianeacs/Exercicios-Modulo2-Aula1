namespace exercicio1
{
    public class Futebol : EsporteBase
    {
        public Futebol()
        {
            QuantidadeJogadoresPorTime = 11;
            TempoDeJogoEmMinutos = 90;
        }

        public override string IniciarJogo()
        {
            return "O jogo foi iniciado";
        }

        public override string FinalizarJogo()
        {
            return "O jogo foi finalizado";
        }

        public override string ExibirDescricao()
        {
            return $"O futebol é um esporte praticado por {QuantidadeJogadoresPorTime}" +
                $" jogadores em cada time durante {TempoDeJogoEmMinutos} minutos";
        }

    }
}
