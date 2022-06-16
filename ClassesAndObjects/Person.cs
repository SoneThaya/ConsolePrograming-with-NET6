// primitive datatypes
// int, string, char, bool

// object oriented programming - creating your own datatype
// class - blueprint

// Single responsibility principle



public class Person
{
    // properties when public
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // fields
    private double _salary { get; set; }

    public void setSalary(double salary)
    {
        _salary = salary;
    }

    public double getSalary()
    {
        return _salary;
    }

    public string getFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public string getFullName(string middleName)
    {
        return $"{FirstName} ${middleName} {LastName}";
    }
 }
