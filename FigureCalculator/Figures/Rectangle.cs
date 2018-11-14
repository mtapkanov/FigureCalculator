using System;
using Solution.Parameters;

namespace Solution.Figures
{
    public class Rectangle : Figure
    {
        public Rectangle(IFigureParameter parameters) : base(parameters)
        {
        }

        protected override double Calculate(IFigureParameter param)
        {
            if (param is RectangleParameter rectangleParameter)
            {
                return rectangleParameter.Length * rectangleParameter.Width;
            }

            throw new InvalidOperationException($"parameters {param.Name} is wrong");
        }
    }
}