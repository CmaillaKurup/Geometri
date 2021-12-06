namespace Geometri
{
    public class Square
    {
        private double a { get; }

        public Square(double a)
        {
            this.a = a;
        }

        public double Perimeter()
        {
            return a * 4;
        }

        public virtual double Areal()
        {
            return a * a;
        }
    }
}