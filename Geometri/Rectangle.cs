namespace Geometri
{
    public class Rectangle : Square
    {
        private double b { get; }

        public Rectangle(double a, double b) : base(a)
        {
            this.b = b;
        }
    }
}