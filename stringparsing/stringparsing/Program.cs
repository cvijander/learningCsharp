
// See https://aka.ms/new-console-template for more information
using System.Globalization;


Console.WriteLine("Hello, World!");


string numStr1 = "1";
string numStr2 = "2.00";
string numStr3 = "3,000";
string numStr4 = "3,000.00";

// The Parse function atempts to parse a string into a number 
// but it might throw an exception, so we need to catch that 




int targetNum = 0;

// TODO: Use Parse to try a simple integer 
try
{
	targetNum = int.Parse(numStr1);
    Console.WriteLine(targetNum);

    // TODO: Use Parse to try a floating point number 
    // This only works if the decimal value is 0 
    targetNum = int.Parse(numStr2, NumberStyles.Float);
    Console.WriteLine(targetNum);


    // TODO: Use Parse to try a number with thousands marker
    targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
    Console.WriteLine(targetNum);


    // TODO: Use Parse to try a number with thousands marker and decimal 
    targetNum = int.Parse(numStr4, NumberStyles.Float | NumberStyles.AllowThousands);
    Console.WriteLine(targetNum);


    // TODO: This works with other types too, like bool 
    Console.WriteLine($"{bool.Parse("True")}");


    // TODO: or floating point numbers
    Console.WriteLine($"{float.Parse("1.235"):F2}");

}
catch (Exception)
{

    Console.WriteLine("Conversion failed");
}

// TODO: The TryParse function is similar but handles the exceptions for us 

bool  succeeded = false;

succeeded = Int32.TryParse(numStr1, out targetNum);
if(succeeded)
{
    Console.WriteLine($"{targetNum}");
}


bool failed = false;
int theNumber =new Random().Next(20);
int numOfGuesses = 0;
Console.WriteLine("Let's play 'Guess the Number'!");
Console.WriteLine("I'm thinking of a number between 0 and 20.");
Console.WriteLine("Enter your guess , or -1 to give up.");

Console.WriteLine("What's your guess? ");
string guess = Console.ReadLine();
int number;
while (guess != "-1")
{
    Console.WriteLine("What's your guess? ");
    guess = Console.ReadLine();
    failed =Int32.TryParse(guess, out number);

    if (failed)
    {
        if (number > theNumber)
        {
            Console.WriteLine("Nope, lower than that");
            numOfGuesses++;
        }
        else if (number < theNumber)
        {
            Console.WriteLine("Nope , higher than that");
            numOfGuesses++;
        }
        else if (number == theNumber)
        {


            Console.WriteLine($"You are right, the number is {number} , and you used only {numOfGuesses}  guesses");
        }
    }

}

// if number is higher than guess 


