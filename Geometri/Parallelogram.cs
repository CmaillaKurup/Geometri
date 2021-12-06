using System;

namespace Geometri
{
    public class Parallelogram : Square
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

        public Parallelogram(double a, double b) : base(a)
        {
            this.b = b;
        }
        
        //TODO: come back and make sure that the formular works - at the moment the result only gives 0
        public override double Areal()
        {
            return a * b * Math.Sin(20.0);
        }
    }
}