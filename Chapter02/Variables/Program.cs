using System.Xml;

object height = 1.88;
object name = "Beef";
Console.WriteLine($"{name} is {height} metres tall.");

// int length1 = name.Length; // gives compiler error
int length2 = ((string)name).Length; // tells compiler it's a string
Console.WriteLine($"{name} has {length2} characters.");

// storing a string in a dynamic object. string has a Length property.
dynamic something = "Beef";

// int does not have a length property
// something = 12;
// an array of any type has a length property
something = new[] { 3, 5, 7 };

Console.WriteLine($"Length is {something.Length}");

var population = 67_000_000; // 67 million in UK
var weight = 1.89; // in kilograms
var price = 4.99M; // in pounds sterling
var fruit = "Apples"; // strings use double quotes
var letter = 'Z'; // chars use single-quotes
var happy = true; // bools have a value of true or false

// good use of var because it avoids the repeated type as shown in the more verbose statement
var xml1 = new XmlDocument(); // C# 3 and later
XmlDocument xml2 = new XmlDocument(); // all C# versions

// bad use of var because we cannot tell the type, so we should use a specific type declaration
// as shown in the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

XmlDocument xml3 = new(); // target-typed new in C# 9 or later

Person beef = new();
beef.BirthDate = new(1981, 06, 02);

List<Person> people = new()
{
    new() { FirstName = "Beef" },
    new() { FirstName = "Sally"},
    new() { FirstName = "Soup"}
};

class Person
{
    public DateTime BirthDate;
    public string? FirstName;
}