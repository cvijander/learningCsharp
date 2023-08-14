// See https://aka.ms/new-console-template for more information

int[] values = { 15, 7, 12, 23, 41, 28, 9, 17, 36 };


Console.WriteLine("Using break and continue:"  );
foreach( var val in values )
{
    if(val >= 20 && val <= 29)
    {
        continue;
    }

    Console.WriteLine( $"Val is {val}" );

  /*  if(val >= 40 )
    {
        break;
    }
  */
}