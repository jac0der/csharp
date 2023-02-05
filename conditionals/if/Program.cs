// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string secret = "secret";

Console.WriteLine("What is the passcode");
var code = Console.ReadLine();

// if statement
if(code == secret)
{
    Console.WriteLine("Authenticated");
}
else if(code != secret)
{
    Console.WriteLine("Not Authenticated");
}
