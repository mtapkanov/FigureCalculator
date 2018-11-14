namespace Solution.Parameters
{
    public class CircleParameter : IFigureParameter
    {
        public CircleParameter(double radius)
        {
            Radius = radius;
        }

        public FigureNames Name { get; } = FigureNames.Circle;
        public double Radius { get; }
    }
}