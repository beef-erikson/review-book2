using System.Reflection;

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