// See https://aka.ms/new-console-template for more information
// Declare some variables to excercise the operators

int x = 10,  y = 5;
string a = "abcd", b = "efgh";

// TODO: Basi math operators are +, - ,/ ,* 
Console.WriteLine("----- Basic Math -----");
Console.WriteLine(  (x /y ) *x);
Console.WriteLine( a + b );


// TODO: Increment / decrement operators 

Console.WriteLine("----- Shorthand -----" );
x++;
y--;
Console.WriteLine( x );
Console.WriteLine( y );

// TODO: Operators can be shorthand: a = a + b

a += b;
Console.WriteLine(  a);


// TODO: Logical operators && , || 
Console.WriteLine("----- Logic Operators -----");
Console.WriteLine( x > y && y >= 5 );
Console.WriteLine( x > y || y >= 5 );


// null-coalescing operators 
  string str = null;

// TODO: the ?? operator uses left operand if not null, or right one if it is null

Console.WriteLine( str ?? "Unknown string" );

// TODO: the ??= operator assigns the right operand if the left one is null 
// it replaces the code:
// if (variable is null) {
// variable =someValue;
// }

str ??= "New string";
Console.WriteLine( str );


