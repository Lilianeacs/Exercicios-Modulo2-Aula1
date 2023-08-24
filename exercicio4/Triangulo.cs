namespace exercicio4
{
    public class Triangulo : Figura
    {
        public double baseTriangulo { get; set; }
        public double altura { get; set; }

        public override string cor 
        { 
            get => cores; 
            set => cores = value; 
        }
        
        public override double area()
        {
            return baseTriangulo * altura;
        }
    }
}
