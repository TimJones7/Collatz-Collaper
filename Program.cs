// See https://aka.ms/new-console-template for more information
using CollatzTesting.Collatz;

Console.WriteLine("Hello, Collatz!");
Console.WriteLine(" ");

CollatzTree tree = new CollatzTree();

//Console.WriteLine("Printing Tree 101:");
//tree.PrintFromNumber(101);
//Console.WriteLine(" ");

//disty.getTallyFromNum(tree, 101);
//Console.WriteLine($"Leading Digit Distribution from {101} => 1");
//disty.printDistribution();

int x = 101;

Console.WriteLine($"Printing Tree {x}:");
tree.PrintFromNumber(x);
Console.WriteLine(" ");

tree._distribution.getTallyFromNum(tree, x);
Console.WriteLine($"Leading Digit Distribution from {x} => 1");
tree._distribution.printDistribution();
Console.WriteLine(" ");

