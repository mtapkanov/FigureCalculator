namespace Solution.Parameters
{
    public class TriangleParameter : IFigureParameter
    {
        public TriangleParameter(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public FigureNames Name { get; } = FigureNames.Triangle;
        public double A { get; }
        public double B { get; }
        public double C { get; }
    }
}