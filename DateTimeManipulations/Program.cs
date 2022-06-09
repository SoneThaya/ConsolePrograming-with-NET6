// See https://aka.ms/new-console-template for more information

// empty DateTime
using System.Globalization;

DateTime date = new DateTime();


// create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1980, 12, 30);
Console.WriteLine("My dob is: " + dateOfBirth);
Console.WriteLine("My dob is: " + dateOfBirth.Date);
Console.WriteLine("Day of the week: " + dateOfBirth.DayOfWeek);
Console.WriteLine("Day of the year: " + dateOfBirth.DayOfYear);
Console.WriteLine("Time of Day: {0} " + dateOfBirth.TimeOfDay);
Console.WriteLine("Tick: {0} " + dateOfBirth.Ticks);
Console.WriteLine("Kind: {0} " + dateOfBirth.Kind);


// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The time is: " + now);


// Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The date from string is: " + dateFromString);

// add additional time
Console.WriteLine("one hour from now is: " + now.AddHours(1));
Console.WriteLine("one day from now is: " + now.AddDays(1));


// ticks from DateTime
Console.WriteLine("Time as a numberal: " + now.Ticks);


// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth.Date);
Console.WriteLine("Date only: " + dateOnlyOfBirth);


// Time Only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine("Time only: " + timeOnly);
