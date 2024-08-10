Console.WriteLine("1.Kahve: ");
string input = Console.ReadLine();
Console.WriteLine("2.Kahve: ");
string input2 = Console.ReadLine();
Console.WriteLine("3.Kahve: ");
string input3 = Console.ReadLine();
Console.WriteLine("4.Kahve: ");
string input4 = Console.ReadLine();
Console.WriteLine("5.Kahve: ");
string input5 = Console.ReadLine();


List<string> coffe = new List<string>();

coffe.Add(input);
coffe.Add(input2);
coffe.Add(input3);
coffe.Add(input4);
coffe.Add(input5);

Console.WriteLine("Girilen Kahve İsimleri ----->");
foreach (string kahve in coffe)
{
    Console.WriteLine(kahve);
}