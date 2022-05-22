// See https://aka.ms/new-console-template for more information
using CollatzTesting.Collatz;

Console.WriteLine("Hello, Collatz!");
Console.WriteLine(" ");

CollatzTree tree = new CollatzTree();
DigitDistribution disty = new DigitDistribution();

Console.WriteLine("Printing Tree 101:");
tree.PrintFromNumber(101);
Console.WriteLine(" ");

disty.getTallyFromNum(tree, 101);
Console.WriteLine($"Leading Digit Distribution from {101} => 1");
disty.printDistribution();


Console.WriteLine("Printing Tree 51:");
tree.PrintFromNumber(51);
Console.WriteLine(" ");

disty.getTallyFromNum(tree, 51);
Console.WriteLine($"Leading Digit Distribution from {51} => 1");
disty.printDistribution();