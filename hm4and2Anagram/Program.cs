namespace hm4and2Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write your anagram words with a space: ");
            string words = Console.ReadLine();
            string[] wordsArr = words.Split(" ");
            string wordOne = wordsArr[0];
            string wordTwo = wordsArr[1];
            string currentLetter = "";

            if (wordsArr[0].Length != wordsArr[1].Length)
            {
                Console.WriteLine("Words are not Anagram");
            }
            else
            {
                for (int i = 0; i < wordsArr.Length; i++)
                {
                    if(wordOne[i] < wordOne[i + 1])
                    {
                       currentLetter = wordOne[i];

                    }
                }
            }
        }
    }
}
