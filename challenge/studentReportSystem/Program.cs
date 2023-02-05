// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool adding = true;

var studentNames = new List<string>();
var studentGrades = new List<int>();

while(adding)
{
    Console.WriteLine("What is the name of student");
    studentNames.Add(Console.ReadLine());

    Console.WriteLine("What is the grade of student");
    studentGrades.Add(int.Parse(Console.ReadLine()));

    Console.WriteLine("Add more y/n");
    string answer = Console.ReadLine();

    if(answer != "y")
        adding = false;
}

Console.WriteLine(studentGrades[0]);

