namespace hm3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // poxel BARERI hertakanutyuny hakaraki

            //Console.WriteLine("Insert a sentence to revert: ");
            //string nonReverted = Console.ReadLine();
            //string reverted = "";

            //for (int i = nonReverted.Length - 1; i >= 0; i--)
            //{
            //    reverted = reverted + nonReverted[i];
            //}
            //Console.WriteLine(reverted);

            // try 2

            Console.WriteLine("Insert a sentence to revert: ");
            string nonReverted = Console.ReadLine();
            string reverted = "";
            int current = 0;

            for (int i = 0; i <= nonReverted.Length - 1; i++)
            {
                if (nonReverted[i] == ' ' || i == nonReverted.Length - 1)
                {
                    for (int ii = i; ii >= current; ii--)
                    {
                        reverted = reverted + nonReverted[ii];
                    }
                    current = i;
                }
            }
            Console.WriteLine(reverted);

        }
    }
}
