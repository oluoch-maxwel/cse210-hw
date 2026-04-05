using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Book book = new Book("Burning Spear", "Chenua Achebe");
    
        Console.WriteLine(book.GetBookInfo());

        PicturedBook myBook = new PicturedBook("Burning Spear", "Chenua Achebe", "John");
    
        Console.WriteLine(myBook.GetIllustratorInfo());
    }
}