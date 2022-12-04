
class Program
{
    static void Main()
    {
    }
}

class books
{
    private string NameBook;
    private int Id;
    private int Pages;

    public books (string nameBook,int id, int page)
    {
        NameBook = nameBook;
        Id = id;
        Pages = page;
    }
}

class Library
{
    int BookQuantity;
    List<books> ListBook = new List<books>();

    public Library()
    {
        BookQuantity = 0;
            
    }

    public void addBook(string nameBook, int id, int page)
    {
        books book = new books(nameBook, id, page);
        ListBook.Add(book);
        BookQuantity++;
    }

    public void PrintAll()
    {
        foreach (books book in ListBook)
        {
            Console.WriteLine(book);
        }
    }
}