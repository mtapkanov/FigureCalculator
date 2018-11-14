namespace Solution.Parameters
{
    public class RectangleParameter : IFigureParameter
    {
        public RectangleParameter(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public FigureNames Name { get; } = FigureNames.Rectangle;
        public double Length { get; }
        public double Width { get; }
    }
}