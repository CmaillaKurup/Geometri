namespace Geometri
{
    public class Triangle : Square
    {
        private double _a;
        public double a
        {
            get
            {
                return _a;
            }
        }
        private double b { get; }
        private double c { get; }

        public Triangle(double a, double b, double c) : base(a)
        {
            this.b = b;
            this.c = c;
        }
        
        public override double Perimeter()
        {
            return a + b + c;
        }

        public override double Areal()
        {
            return 0.5 * a * b;
        }
        
    }
}