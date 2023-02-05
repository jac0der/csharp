// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string secret = "secret";
var code = "";

while(code != secret)
{
    Console.WriteLine("What is the passcode");
    code = Console.ReadLine();

    if(code != secret)
    {
        Console.WriteLine("Not Authenticated");
    }
}

// code is now equalk to secret
Console.WriteLine("Authenticated");

