// See https://aka.ms/new-console-template for more information


string inputStr = "";

// TODO basic while loop 

Console.WriteLine( "Basic while loop:" );
/*
while ( inputStr !="exit" )
{
    inputStr = Console.ReadLine();
    Console.WriteLine("You entered: {0}",inputStr );
}
Console.WriteLine(  );
*/

// TODO the do while loor always executes at least one time 
Console.WriteLine( "The do while loop" );
do {
    inputStr = Console.ReadLine();
    Console.WriteLine("You entered: {0}",inputStr  );
} while ( inputStr !="exit" );
Console.WriteLine(  );

