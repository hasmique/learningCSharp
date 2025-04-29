using System;
using System.Collections.Generic;

namespace Mory.ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Demo");
                    input = "1+2*(6+9*2)+8";
                }

                if (input == "exit")
                {
                    break;
                }

                if (input == "clear")
                {
                    Console.Clear();
                    continue;
                }

                input = input.Replace(" ", "");

                Calculate(input);
            }
        }

        static decimal Calculate(string input)
        {
            if (!input.EndsWith('='))
            {
                input += '=';
            }

            Console.WriteLine(input);

            var expressions = new List<object>();

            string temp = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] is >= '0' and <= '9' or '.')
                {
                    temp += input[i];
                }
                else
                {
                    if (temp.Length > 0)
                    {
                        expressions.Add(Decimal.Parse(temp));
                        temp = String.Empty;
                    }

                    expressions.Add(input[i]);
                }
            }

            WriteExpressions(expressions);

            static decimal calcSimple(List<object> expressions)
            {
                Console.WriteLine("Calculating simple expression");

                bool changed = true;

                while (changed && expressions.Count > 1)
                {
                    WriteExpressions(expressions);

                    changed = false;

                    for (int i = 0; i < expressions.Count - 2; i++)
                    {
                        if (expressions[i] is decimal left && expressions[i + 1] is '*' or '/' && expressions[i + 2] is decimal right)
                        {
                            expressions[i] = (char)expressions[i + 1] switch
                            {
                                '*' => left * right,
                                '/' => left / right,
                                _ => throw new InvalidOperationException()
                            };

                            expressions.RemoveRange(i + 1, 2);

                            changed = true;

                            break;
                        }
                    }

                    if (changed)
                    {
                        continue;
                    }

                    for (int i = 0; i < expressions.Count - 2; i++)
                    {
                        if (expressions[i] is decimal left && expressions[i + 1] is '+' or '-' && expressions[i + 2] is decimal right)
                        {
                            expressions[i] = (char)expressions[i + 1] switch
                            {
                                '+' => left + right,
                                '-' => left - right,
                                _ => throw new InvalidOperationException()
                            };

                            expressions.RemoveRange(i + 1, 2);

                            changed = true;

                            break;
                        }
                    }
                }

                WriteExpressions(expressions);

                return (decimal)expressions[0];
            }

            var startIndex = -1;

            while ((startIndex = expressions.FindLastIndex(i => i is '(')) != -1)
            {
                var endIndex = expressions.FindIndex(startIndex, i => i is ')');
                var subExpressions = expressions.GetRange(startIndex + 1, endIndex - startIndex - 1);

                expressions.RemoveRange(startIndex, endIndex - startIndex + 1);

                var result = calcSimple(subExpressions);

                expressions.Insert(startIndex, result);
            }

            return calcSimple(expressions);
        }

        private static void WriteExpressions(List<object> expressions)
        {
            Console.WriteLine(String.Join(' ', expressions));
        }
    }
}
