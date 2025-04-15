namespace hm22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tpel hakarak teq gic

            Console.WriteLine("Insert * numbers to proceed: ");
            string asterixNumber = Console.ReadLine();
            int astQuantity = int.Parse(asterixNumber);

            for (int i = astQuantity; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}
