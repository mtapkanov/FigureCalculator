using System;

namespace Solution
{
    public abstract class Figure
    {
        protected IFigureParameter Parameters { get; }
        
        protected Figure(IFigureParameter parameters)
        {
            Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        }

        public double OnCalculate()
        {
            if (!Enum.IsDefined(typeof(FigureNames), Parameters.Name))
                throw new ArgumentOutOfRangeException("Unknown parameter");

            return Calculate(Parameters);
        }

        protected abstract double Calculate(IFigureParameter param);
    }
}