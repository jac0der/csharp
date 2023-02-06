// See https://aka.ms/new-console-template for more information

/* 
    class variables cannot be defined with the var keyword
    only local variables.
*/

// define Person object
var person = new Person();

// creating a nullable type
int? year = null;


/*
    The C# double question mark operator ?? is known as the null 
    coalescing operator.
    In a nutshell, the null coalescing operator is "if the first 
    value is null, use this other value."
    Null coalescing operator is a binary operator that takes two 
    operands: the first operand is an expression that can be null, 
    and the second operand is the value that you want to assign to 
    the expression if it is not null.
*/
var personValue = person ?? new Person()
{
    first_name = "Jim",
    last_name = "bo"
};

// var personValue = (person != null) ? person : new Person();


DateTime? shipDate = null;
DateTime shipOn = shipDate ?? DateTime.MaxValue;
Console.WriteLine(shipOn); // 12/31/9999 11:59:59 PM


var my_string = "My String!";
string current_weather = "rainy";

int age = 20;

decimal cost = (decimal)22.42;
float valuation = (float)875.35;
double value = 45.24;































