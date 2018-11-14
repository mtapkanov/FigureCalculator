using System;
using Solution.Parameters;

namespace Solution.Figures
{
    public class Triangle : Figure
    {
        public Triangle(IFigureParameter parameters) : base(parameters)
        {
        }

        protected override double Calculate(IFigureParameter param)
        {
            var parameter = GetTriangleParameter(param);
            var p = 0.5 * (parameter.A + parameter.B + parameter.C);
            return Math.Sqrt(p * (p - parameter.A) * (p - parameter.B) * (p - parameter.C));
        }

        public bool IsRight
        {
            get
            {
                var parameter = GetTriangleParameter(Parameters);
                var a = parameter.A;
                var b = parameter.B;
                var c = parameter.C;
                return IsPythagorasTriangle(a, b, c) || IsPythagorasTriangle(a, c, b) || IsPythagorasTriangle(c, b, a);

                bool IsPythagorasTriangle(double leg1, double leg2, double hypotenuse)
                {
                    return Math.Pow(leg1, 2) + Math.Pow(leg2, 2) == Math.Pow(hypotenuse, 2);
                }
            }
        }

        private TriangleParameter GetTriangleParameter(IFigureParameter parameter)
        {
            if (parameter is TriangleParameter param)
                return param;

            throw new InvalidOperationException($"parameters {parameter.Name} is wrong");
        }
    }
}