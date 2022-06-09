// See https://aka.ms/new-console-template for more information

string firstName = "Trevoir";
string lastName = "Williams";
DateTime date = DateTime.Now;


// print to screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed");


// Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("my full name is " + lastName + " " + firstName);
Console.WriteLine($"my full name is {lastName}, {firstName}");
Console.WriteLine("my full name is {0}, {1}", lastName, firstName);


// string length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long");


// replace string parts
string newName = firstName.Replace('T', 'K');
Console.WriteLine($"your new name is {newName}");

string newName1 = firstName.Replace('i', ' ');
Console.WriteLine($"your new name is {newName1}");


// append to other string variable
string fullname = firstName + " " + lastName;
Console.WriteLine($"your fullname is {fullname}");


// spit string
string[] splitName = fullname.Split('v');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}



string nullString = null;
string emptyString = "";
string whitespacestirng = " ";
// compare strings
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if (firstName == lastName)
{
    Console.WriteLine("names are equal");
}

if (firstName != lastName)
{
    Console.WriteLine("names are not equalt");
}


int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("names are equal");
}
else
{
    Console.WriteLine("names are not equal");
}


// convert strings
string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();
convertedString = 987654321.ToString();


fullname.ToUpper();
fullname.ToLower();