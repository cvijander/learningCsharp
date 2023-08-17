// See https://aka.ms/new-console-template for more information

// TODO: Ordinary value arguments cannot be modified by the function
// because they are a copy of original value

int val1 = 10;
int val2 = 20;




// Function don't normally modify value  arguments 
TestFunc1(val1);
Console.WriteLine($"{val1}");
TestFunc2(ref val2);
Console.WriteLine($"{val2}");

int a, b;
PlusTimes(val1, val2, out a, out b);
Console.WriteLine($"{a}, {b}");



static void TestFunc1 (int arg1)
{
    arg1 += 10;
    Console.WriteLine($"{arg1}");
}

// TODO: Arguments that are passed by reference can be modified 
// by the function and reflected back to the caller 
static void TestFunc2(ref int arg1)
{
    arg1 += 10;
    Console.WriteLine($"{arg1}");
}

// TODO: The "out" keyword means that the parameter returns a value and is not 
// used ti supply data to the function 

static void PlusTimes (int arg1, int arg2, out int sum, out int product)
{
    sum = arg1 + arg2;
    product = arg1 * arg2;
}
