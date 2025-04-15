namespace hm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // trvac e 3 INT (3 popoxakan), gtnel amenamecin miayn IFerov, aranc cikl
            //poxel arjeqnery dasavorelov mecic poqr

            Console.WriteLine("Insert 3 inputs using just a space: ");
            string userInputs = Console.ReadLine();
            int num1, num2, num3;
            string a1, a2, a3;

            int firstSpaceFinder = userInputs.IndexOf(' ');
            num1 = int.Parse(userInputs.Substring(0, firstSpaceFinder));

            int secondSpaceFinder = userInputs.LastIndexOf(' ');
            num2 = int.Parse(userInputs.Substring(firstSpaceFinder, secondSpaceFinder - firstSpaceFinder));
            num3 = int.Parse(userInputs.Substring(secondSpaceFinder));

            Console.WriteLine("Your input 1 is: " + num1);
            Console.WriteLine("Your input 2 is: " + num2);
            Console.WriteLine("Your input 3 is: " + num3);

            int numMax = 0;
            int numMin = 0;
            int midNum = 0;

            if (num1 >= num2 && num1 >= num3)
            {
                numMax = num1;
                if (num2 > num3)
                {
                    numMin = num3;
                    midNum = num2;
                }
                else
                {
                    numMin = num2;
                    midNum = num3;
                }
            }

            if (num2 >= num1 && num2 >= num3)
            {
                numMax = num2;

                if (num1 >= num3)
                {
                    numMin = num3;
                    midNum = num1;
                }
                else
                {
                    numMin = num1;
                    midNum = num3;
                }
            }

            if (num3 >= num1 && num3 >= num2)
            {
                numMax = num3;
                if (num1 > num2)
                {
                    numMin = num2;
                    midNum = num1;
                }
                else
                {
                    numMin = num1;
                    midNum = num2;
                }
            }
            Console.WriteLine("Max Number is: " + numMax + " Mid Number is: " + midNum + " Min Number is: " + numMin);


        }
    }
}
