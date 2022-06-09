// See https://aka.ms/new-console-template for more information

// Prototype - Defines the function (type, name and paramters)
// Definition - Has the code. It contains the code block for the function
// Function call - Makes the function
// DRY - dont repeat yourself
// YAGNI - you aint going to need it

// Void Functions - completes a task and moves along, doesn't return anything
void PrintName()
{
    Console.WriteLine("Trevioir Williams");
}

void Addition(int num1, int num2)
{
    Console.WriteLine($"the sum of {num1} and {num2} is {num1 + num2}");
}

// Value Returning Functions - completes a task, returns a result
int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    if (largest < num2)
    {
        largest = num2;
    } 
    if (largest < num3)
    {
        largest = num3;
    }

    return largest;
}



PrintName();
Console.WriteLine("End of void function");

Console.Write("enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);

Console.Write("enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = LargestNumber(number1, number2, number3);
Console.WriteLine($"The largest number is: {result}");

//Console.WriteLine($"The largest number is: {LargestNumber(number1, number2, number3)}");