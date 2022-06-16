// See https://aka.ms/new-console-template for more information

Person person = new(); // Person person = new Person();

string middleName = string.Empty;

Console.WriteLine("Enter first name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter last name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter age: ");
person.Age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter Salary: ");
int salary = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter middlename: ");
middleName = Console.ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Full name is:  " + person.getFullName());
}
else
{

    Console.WriteLine("Full name is:  " + person.getFullName(middleName));
}


person.setSalary(salary);

Console.WriteLine("First Name is: " + person.FirstName);
Console.WriteLine("Last Name is: " + person.LastName);


//Console.WriteLine("Full name is: " + person.getFullName());

Console.WriteLine("Age is: " + person.Age);
Console.WriteLine("year of birth is: " + DateUtil.YearOfBirth(person.Age));
Console.WriteLine("Salary is: " + person.getSalary());

