using Demo.MyCustomLib;

Console.WriteLine("Hello, World!");
Console.Write("Please enter your name: ");
string name = Console.ReadLine();

if (!string.IsNullOrEmpty(name))
{
    System.Console.WriteLine(GreetingHelper.GetGreetingMessage(name));
}
