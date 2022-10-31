using System.Reflection;

// declare some unused variables using types in additional assemblies
System.Data.DataSet ds;
HttpClient client;

Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp == null) return;  // quit app

// Loop through assemblies
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // load assembly to read details
    Assembly a = Assembly.Load(name);
    int methodCount = 0;

    // loop through all types and their methods
    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Count();
    }

    // output
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}

// Let the heightInMetres variable become equal to the value 1.88
double heightInMetres = 1.88;
Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");

string firstName = "Beef";
string lastName = "Erikson";
string phoneNumber = "(814) 828-8716";

// assigning a string returned from the string class constructor
string horizontalLine = new('-', count: 74);

// assigning an emoji by converting from unicode
Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);

// verbatim literal string
string filePath = @"C:\televisions\sony\bravia.txt";

string xml = """
    <person age="50">
      <first_name>Beef</first_name>
    </person>
    """;
Console.WriteLine(xml);

// raw interpolated string literals - specify number of braces by adding that number of dollar signs to the 
// start of the lieral. Any fewer braces will be treated as raw content.
var person = new { FirstName = "Beef", Age = 41 };

// the number of dollars tells the compiler how mmany curly braces are needed for something to become
// recognized as an interpolated expression.
string json = $$"""
{
    "first_name": "{{person.FirstName}}",
    "age": {{person.Age}},
    "calculation", "{{{1 + 2}}}"
}
""";
Console.WriteLine(json);