// See htt
// ps://aka.ms/new-console-template for more information

// classes have a name, unique within the namespace

Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
Book b2 = new Book("The grapes of Wrath", "John Steinbeck", 464);

Console.WriteLine(b1.GetDescription());
Console.WriteLine(b2.GetDescription());
public class Book
{
    // TODO: classes have member variables, or "fields" to hold data
    string _name;
    string _author;
    int _pagecount;


    // TODO: classes have one or more constructors 
    public Book(string name, string author, int pages )
    {
        _name = name;   
        _author = author;
        _pagecount = pages;
    }


    // TODO: methods are used to operate on the class and data
    public string GetDescription()
    {
        return $"{_name} by {_author}";
    }


}



//