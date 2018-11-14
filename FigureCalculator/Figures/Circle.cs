using System;
using Solution.Parameters;

namespace Solution.Figures
{
    public class Circle : Figure
    {
        private const double Pi = Math.PI;

        public Circle(IFigureParameter parameters) : base(parameters)
        {
        }

        protected override double Calculate(IFigureParameter param)
        {
            if (param is CircleParameter circleParameter)
            {
                return Pi * Math.Pow(circleParameter.Radius, 2);
            }

            throw new InvalidOperationException($"parameters {param.Name} is wrong");
        }
    }
}