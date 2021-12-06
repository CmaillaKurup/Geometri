namespace Geometri
{
    public class Form
    {
        private Square _square { get; set; }
        private Rectangle _rectangle { get; set; }
        private Trapezoid _trapezoid { get; set; }
        private Parallelogram _parallelogram { get; set; }
        private Triangle _triangle { get; set; }

        public Form(Square square, Rectangle rectangle, Trapezoid trapezoid, Parallelogram parallelogram, Triangle triangle)
        {
            _square = square;
            _rectangle = rectangle;
            _trapezoid = trapezoid;
            _parallelogram = parallelogram;
            _triangle = triangle;
        }
    }
}