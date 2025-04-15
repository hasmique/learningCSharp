using System;
using static System.Console;

//guess the number

var randomNumber = Random.Shared.Next(1, 100);
int trying = 0;
int maxNum = 99;
int minNum = 0;

while (true)
{
    Write("Try {0}:", trying);

    string inp = Console.ReadLine();
    int guess = 0;

    if (string.IsNullOrWhiteSpace(inp))
    {
        WriteLine("Wrong input");
        continue;
    }

    bool converted = Int32.TryParse(inp, out guess);

    if (guess < minNum || guess > maxNum)
    {
        WriteLine("This doen't count.Try any number from the Hint's list!");

        for (int k = 0; k < 100; k++)
        {
            if (k % 10 == 0)
            {
                WriteLine("");
            }

            if (minNum < k && k < maxNum)
            {
                if (k < 10)
                {
                    Write("0" + k + " ");
                }
                else
                {
                    Write(k + " ");
                }


            }
            else
            {
                //Write("XX" + " ");
                Write("\u007C");
                Write("\u00AF");
            }
        }
        WriteLine("");
        WriteLine("Good luck next time");
        continue;
    }

    if (guess > randomNumber)
    {
        maxNum = guess;
        trying++;

        WriteLine("Your number is bigger");

        for (int k = 0; k < 100; k++)
        {
            if (k % 10 == 0)
            {
                WriteLine("");
            }

            if (minNum < k && k < maxNum)
            {
                if (k < 10)
                {
                    Write("0" + k + " ");
                }
                else
                {
                    Write(k + " ");
                }


            }
            else
            {
                Write("XX" + " ");
            }
        }
        WriteLine("");
        WriteLine("Good luck next time");
    }

    if (guess < randomNumber)
    {
        minNum = guess;
        trying++;

        WriteLine("Your number is smaller");

        for (int k = 0; k < 100; k++)
        {
            if (k % 10 == 0)
            {
                WriteLine("");
            }

            if (minNum < k && k < maxNum)
            {
                if (k < 10)
                {
                    Write("0" + k + " ");
                }
                else
                {
                    Write(k + " ");
                }


            }
            else
            {
                Write("XX" + " ");
            }
        }
        WriteLine("");
        WriteLine("Good luck next time");

    }

    if (guess == randomNumber)
    {
        WriteLine("Congrats! You got it. It is " + randomNumber);
        return;
    }

    if (trying == 10)
    {
        WriteLine("You Lost!");
        WriteLine("The winning number was " + randomNumber);
        return;
    }
}

for (int i = 1; i <= 100; i++)
{
    Write("\u007C");
    Write("\u00AF");
    //if(i == 0)
    //{
    //    Write("\u007C\u00AF\u005F\u007C");
    //}

    if (i > 9 && i % 10 == 0)
    {
        WriteLine("");
    }
}
