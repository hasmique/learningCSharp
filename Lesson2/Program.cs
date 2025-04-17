// task 1 > sarqel array 100, lcnel hertakan tverov, veradasavorel hakarak kargov

//int[] myArray = new int[100];

//for (int i = 0; i < myArray.Length; i++)
//{
//    myArray[i] = i;
//}

//Array.Reverse(myArray);
//Console.WriteLine("Ordered: " + string.Join(", ", myArray));

//Task 2 trvac anun azganuni arjin tarery dardznel mecatar. "vahan m" takuc, stanal "Vahan M"

string fullName = "vahan mkh";

int lastNameIndex = 0;

for (int i = 0; i < fullName.Length; i++)
{
    if(fullName[i] ==  ' ')
    {
        lastNameIndex = i + 1;
        break;
    }
}

string upperCaseName = fullName.Substring(0, 1).ToUpper()+ fullName.Substring(1, 1) + fullName.Substring(lastNameIndex, 1) + fullName.Substring(lastNameIndex+1);

Console.WriteLine(upperCaseName);

//task 3 hashvel tareri krknutyunneri qanaky. mutqin ktrvi orinak "Baraev Arev", petq a stanal 2 array ['b', 'a', 'r', 'e',] [1, 2, 1]

//String myString = "Barev Arev";
//String[] letters = [myString.Length];

//for (int i = 0;i < myString.Length; i++)
//{
//    if (myString[i] == ' ')
//}

//task 4 array-y lcnel ptahakan tverov ( Random.Shared.Next(1, 100) ) , aynuhetev hashvel Min, ev Max