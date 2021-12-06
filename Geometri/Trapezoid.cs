namespace Geometri
{
    public class Trapezoid : Square
    {
        private double b { get; }

        public Trapezoid(double a, double b) : base(a)
        {
            this.b = b;
        }
    }
}