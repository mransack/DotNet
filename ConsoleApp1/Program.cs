// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ConsoleApp1;

string input = "DDD example CQRS Event Sourcing";
string ouput = "";
var splitArray = input.Split(' ');

var selected = splitArray.Where(x => x.Equals(x.ToUpper())).ToList();

Console.WriteLine(string.Join(" ", selected));


//foreach (var split in splitArray)
//{
//    bool checkWord = false;
//    for (int i = 0; i < split.Length; i++)
//    {
//        if (split[i] < 94)
//        {
//            checkWord = false;
//        }
        
//    }
//    if (checkWord) ouput += split;
//}
//Console.WriteLine(ouput);
//Console.WriteLine("A"+1);

//public record Person(string Name, int Age);
Record person = new("Masud", 29);

Console.WriteLine(person.Name);