namespace Geometri
{
    public class Triangle
    {
        private double a { get; }
        private double b { get; }
        private double c { get; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        
        public double Perimeter()
        {
            return a + b + c;
        }

        public double Areal()
        {
            return 0.5 * a * b;
        }
        
    }
}