// See https://aka.ms/new-console-template for more information

// TODO: Functions can provide default values for their parameters
void PrintWithPrefix(string theStr, string prefix="")
{
    Console.WriteLine($"{prefix} {theStr}");
}

// TODO: Test the default parameters
PrintWithPrefix("Hello There! ");
PrintWithPrefix("Hell There!", ">: ");


// TODO: Call with named params 
PrintWithPrefix(prefix: "% ", theStr: "Hello There!");



