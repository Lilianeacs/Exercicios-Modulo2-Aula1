namespace exercicio1
{
    public abstract class EsporteBase
    {
        public int QuantidadeJogadoresPorTime { get; set; }
        public int TempoDeJogoEmMinutos { get; set; }

        public abstract string IniciarJogo();
        public abstract string FinalizarJogo();
        public abstract string ExibirDescricao();
    }
}
