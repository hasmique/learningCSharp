using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mory.ConsoleCalculator
{
    interface IExpressin
    {
        IExpressin Calculate();
    }

    class NumberExpressin(decimal value) : IExpressin,
        IAdditionOperators<NumberExpressin, NumberExpressin, NumberExpressin>,
        ISubtractionOperators<NumberExpressin, NumberExpressin, NumberExpressin>,
        IMultiplyOperators<NumberExpressin, NumberExpressin, NumberExpressin>,
        IDivisionOperators<NumberExpressin, NumberExpressin, NumberExpressin>
    {
        public decimal Value { get; set; } = value;

        public IExpressin Calculate() => this;

        public static NumberExpressin operator +(NumberExpressin left, NumberExpressin right)
            => new(left.Value + right.Value);

        public static NumberExpressin operator -(NumberExpressin left, NumberExpressin right)
            => new(left.Value - right.Value);

        public static NumberExpressin operator *(NumberExpressin left, NumberExpressin right)
            => new(left.Value * right.Value);

        public static NumberExpressin operator /(NumberExpressin left, NumberExpressin right)
            => new(left.Value / right.Value);
    }

    class ParenthesizedExpression : IExpressin
    {
        public IExpressin Inner { get; set; } = null!;
        public IExpressin Calculate() => this.Inner.Calculate();
    }

    class AddExpressin(IExpressin left, IExpressin right) : IExpressin
    {
        public IExpressin Left { get; set; } = left;

        public IExpressin Right { get; set; } = right;

        public IExpressin Calculate() => (NumberExpressin)this.Left.Calculate() + (NumberExpressin)this.Right.Calculate();
    }

    class SubtractExpression(IExpressin left, IExpressin right) : IExpressin
    {
        public IExpressin Left { get; set; } = left;

        public IExpressin Right { get; set; } = right;

        public IExpressin Calculate() => (NumberExpressin)this.Left.Calculate() - (NumberExpressin)this.Right.Calculate();
    }

    class MultiplyExpression(IExpressin left, IExpressin right) : IExpressin
    {
        public IExpressin Left { get; set; } = left;
        public IExpressin Right { get; set; } = right;
        public IExpressin Calculate() => (NumberExpressin)this.Left.Calculate() * (NumberExpressin)this.Right.Calculate();
    }

    class DivideExpression(IExpressin left, IExpressin right) : IExpressin
    {
        public IExpressin Left { get; set; } = left;
        public IExpressin Right { get; set; } = right;
        public IExpressin Calculate() => (NumberExpressin)this.Left.Calculate() / (NumberExpressin)this.Right.Calculate();
    }

    internal class Expressions
    {
        static void Calc()
        {
            string input = "45+89";
            int position = 0;

            IExpressin read()
            {
                IExpressin left;
                IExpressin right;
                char operation = ' ';

                switch (input[position])
                {
                    case >= '0' and <= '9':
                        var number = String.Empty;

                        for (int i = position; i < input.Length; i++)
                        {
                            if (input[i] is not >= '0' or not <= '9')
                            {
                                break;
                            }

                            number += input[i];
                        }

                        position += number.Length;

                        return new NumberExpressin(decimal.Parse(number));
                    case '+' or '-' or '*' or '/':
                        operation = input[position];
                        left = read();
                        break;
                    default:
                        throw new NotSupportedException($"Unsupported character: {input[0]}");
                }
                return null;
            }

            var expression = read();

            var result = (NumberExpressin)expression.Calculate();

            Console.WriteLine(result.Value);
        }
    }
}
