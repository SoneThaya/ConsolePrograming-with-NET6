// See https://aka.ms/new-console-template for more information


// For loop (counter controlled)
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i}");
}
Console.WriteLine();
Console.WriteLine("For loop finished!");


// while loop (condition controlled - pre check)
int n = 0;

while (n < 5)
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}");
}

Console.WriteLine();
Console.WriteLine("While loop finished");


// do while loop (condition controlled - post check)
int m = 0;
do
{
    Console.WriteLine("Input a number: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"you entered {m}");
} while (m < 5);



// foreach - honorable mention
foreach (var item in collection)
{

}