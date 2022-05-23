// See https://aka.ms/new-console-template for more information
using CollatzTesting.Collatz;

Console.WriteLine("Hello, Collatz!");
Console.WriteLine(" ");

CollatzTree tree = new CollatzTree();
DigitDistribution disty = new DigitDistribution();

//Console.WriteLine("Printing Tree 101:");
//tree.PrintFromNumber(101);
//Console.WriteLine(" ");

//disty.getTallyFromNum(tree, 101);
//Console.WriteLine($"Leading Digit Distribution from {101} => 1");
//disty.printDistribution();


Console.WriteLine("Printing Tree 51:");
tree.PrintFromNumber(51);
Console.WriteLine(" ");

disty.getTallyFromNum(tree, 501);
Console.WriteLine($"Leading Digit Distribution from {501} => 1");
disty.printDistribution();
Console.WriteLine(" ");

disty.getTallyFromNum(tree, 5001);
Console.WriteLine($"Leading Digit Distribution from {5001} => 1");
disty.printDistribution();
Console.WriteLine(" ");

disty.getTallyFromNum(tree, 50001);
Console.WriteLine($"Leading Digit Distribution from {50001} => 1");
disty.printDistribution();
Console.WriteLine(" ");

disty.getTallyFromNum(tree, 500001);
Console.WriteLine($"Leading Digit Distribution from {500001} => 1");
disty.printDistribution();
Console.WriteLine(" ");

