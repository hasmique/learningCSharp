namespace hm21_saquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tpel qarakusi

            Console.WriteLine("Insert * number to draw a square: ");
            string asterixNumber = Console.ReadLine();
            int astQuantity = int.Parse(asterixNumber);

            for (int j = astQuantity; j > 0; j--)
            {
                Console.Write('*');
            }

            for (int i = 0; i < astQuantity - 2; i++)
            {
                Console.WriteLine();
                Console.Write('*');
                for (int k = 0; k < astQuantity - 2; k++)
                {
                    Console.Write(' ');

                }
                Console.Write('*');
            }
            Console.WriteLine();
            for (int j = astQuantity; j > 0; j--)
            {
                Console.Write('*');
            }
        }
    }
}
