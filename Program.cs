// See https://aka.ms/new-console-template for more information
using CollatzTesting.Collatz;

Console.WriteLine("Hello, Collatz!");

Console.WriteLine(" ");


CollatzTree tree = new CollatzTree();


Console.WriteLine("Printing Tree 5:");
tree.PrintFromNumber(5);


Console.WriteLine("Printing Tree 21:");
tree.PrintFromNumber(21);


Console.WriteLine("Printing Tree 101:");
tree.PrintFromNumber(101);