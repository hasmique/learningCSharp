namespace simpleMinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        return;

                    default:
                        Console.WriteLine("Type your equations: ");
                        break;
                }

                string response = Console.ReadLine();
                int firstArg = 0;
                string myOperator = "+";
                int secondArg = 1;
                int result = 0;

                for (int i = 0; i < response.Length; i++)
                {
                    if (response[i] == '+' || response[i] == '-' || response[i] == '/' || response[i] == '*')
                    {
                        firstArg = int.Parse(response.Substring(0, i));
                        myOperator = response.Substring(i, 1);
                        secondArg = int.Parse(response.Substring(i + 1));
                    }
                }

                result = myOperator switch
                {
                    "+" => firstArg + secondArg,
                    "-" => firstArg - secondArg,
                    "/" => firstArg / secondArg,
                    "*" => firstArg * secondArg,
                    _ => 0,// Console.WriteLine("No Operator Found");
                };

                Console.WriteLine($"For {response} the answer is  {result}");
                
            }
        }
    }
}

