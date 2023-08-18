// See https://aka.ms/new-console-template for more information


// Create a new Book object 
using properties;

Book b1 = new Book("War and peace", "Leo Tolstoy",825);

//Access a couple of properties 

Console.WriteLine(b1.Name);
Console.WriteLine(b1.Description);

// Set the ISBN and Price properties 

b1.ISBN = "10012352545";
b1.Price = 24.95m;
Console.WriteLine(b1.ISBN);
Console.WriteLine(b1.Price);

// Chenge the Name and Pagecount 

b1.Name = "Crime and punishment";
b1.Pagecount = 652;
Console.WriteLine(b1.Description);
Console.WriteLine(b1.Name);
Console.WriteLine(b1.Pagecount);