// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numberofOranges = Convert.ToInt32(Console.ReadLine());

// If statements
if (numberOfApples > numberofOranges)
{
    Console.WriteLine("You have more apples");
}
else if (numberOfApples < numberofOranges)
{
    Console.WriteLine("you have more oranges");
}
else if (numberOfApples == numberofOranges)
{
    Console.WriteLine("you have the same number of apples and oranges");
}



// switch statements
Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

switch(grade)
{
    case int n when (n <= 59):
        Console.WriteLine("You Failed!");
        break;
    case int n when n >= 60:
        Console.WriteLine("You Passed!");
        break;
    default:
        Console.WriteLine("Invalid grade");
        break;
}



// ternary operator
//var message = numberOfApples > numberofOranges ? "you have more apples" : "you have more oranges";
//Console.WriteLine(message);
