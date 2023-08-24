namespace exercicio4
{
    public class Retangulo : Figura
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }

        public override string cor
        {
            get => cores;
            set => cores = value;
        }
        public override double area()
        {
            return lado1 * lado2;
        }

    }
}
