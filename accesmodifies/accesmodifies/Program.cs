// See https://aka.ms/new-console-template for more information

using accesmodifies;

Book b1 = new Book("War and peace", "Leo Tolstoy", 825);

b1._name = "Cat in the hat";
Console.WriteLine(b1.GetDescription());

b1.SetName("Grapes of Wrath");
b1.SetAuthor("John Steinbeck");
b1.SetPageCount(464);

Console.WriteLine(b1.GetDescription());



