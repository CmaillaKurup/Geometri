namespace Geometri
{
    public class Trapezoid : Square
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
        private double d { get; }
        private double h;

        public Trapezoid(double a, double b, double c, double d) : base(a)
        {
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override double Areal()
        {
            //ms are interim account of s
            double ms1 = a + b;
            double ms2 = c + d;
            double ms3 = ms1 - ms2;
            double s = ms3 / 2;

            //mh are interim account of h
            double mh1 = a - c;
            double mh2 = 2 / mh1;

            double mh3 = s - a + c;
            double mh4 = s - b;
            double mh5 = s - d;

            double mh6 = s * mh3 * mh4 * mh5;

            double h = mh2 * mh6;
            
            //ma are interim account of aa (A)
            double ma1 = a + c;
            double aa = 0.5 * ma1 * h;
            
            return aa;
        }
    }
}