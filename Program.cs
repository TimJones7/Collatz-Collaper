// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(" ");



SortedList<int, string> openWith = new SortedList<int, string>();

openWith.Add(4, "notepad.exe");
openWith.Add(8, "wordpad.exe");




if (openWith.ContainsKey(4))
{
    Console.WriteLine(openWith[4]);
}

if (!openWith.ContainsKey(1))
{
    Console.WriteLine("Key: {1} does not exist");
}
