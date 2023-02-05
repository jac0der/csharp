// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// set all grades in 1 line by initializing
var studentGrades = new int[]{ 80, 75, 95, 93, 88, 80};

Console.WriteLine(studentGrades[4]);

foreach(var grade in studentGrades)
{
    Console.WriteLine(grade);
}
