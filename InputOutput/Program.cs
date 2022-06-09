// See https://aka.ms/new-console-template for more information

// Declare Variable
/*
    Data types
    string - Words/number (name, license plate number) - "" double quotes for strings
    int - whole numbers | double/float - decimals
    char - one character ('A', '7', '%') - single quotes for char
 */

string fullName; // camelCase for variables

// Allow user input and store in variable
Console.WriteLine("Enter your fullname: ");
fullName = Console.ReadLine();

// print contents of variable/user's input
Console.Write(" Your full name is: ");
Console.WriteLine(fullName);