namespace hm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // mek cikli ev IFeri mijocov tpel ankyunain gic. orinak
            Console.WriteLine("Insert the line number: ");
            string lineHeght = Console.ReadLine();
            int heightNum = int.Parse(lineHeght);
            string space = " ";
            string astx = "*";

            for (int i = 0; i < heightNum; i++)
            {
                if (i == 0)
                {
                    Console.Write(astx);
                }

                if (i > 0)
                {
                    space = space + ' ';
                }
                Console.WriteLine();
                Console.Write(space);
                Console.Write(astx);
            }
        }
    }
}
