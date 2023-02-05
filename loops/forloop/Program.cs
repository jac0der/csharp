// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for(int i=0; i <= 10; i++)
{
    Console.WriteLine(i);
}

// count from 1 to 10 then back down to 1 5 times
int times = 1;

while(times <= 5)
{
    for(int i=1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }

    for(int i=10; i > 0; i--)
    {
        Console.WriteLine(i);
    }

    times++;
}

