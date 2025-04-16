namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //palindrome

            Console.WriteLine("insert a word to check palindrome: "); {
                string word = Console.ReadLine();

                string one ="";
                string two = word.Substring(word.Length / 2);


                if (word.Length % 2 != 0)
                {
                    two = word.Substring(word.Length / 2 + 1);
                    for (int i = word.Length / 2; i > 0; i--)
                    {
                        one = one + word[i - 1];
                    }

                    if (one == two)
                    {
                        Console.WriteLine($"{word} is palindrome");
                    }
                    else
                    {
                        Console.WriteLine($"{word} is NOT palindrome");
                    }
                }
                else
                {

                    for (int i = word.Length / 2; i > 0; i--)
                    {
                        one = one + word[i - 1];
                    }

                    if (one == two)
                    {
                        Console.WriteLine($"{word} is palindrome");
                    }
                    else
                    {
                        Console.WriteLine($"{word} is NOT palindrome ");
                    }
                }
            }
        }
    }
}

