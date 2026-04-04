using Day9;


Book[] books =
{
    new Book("978-3-16-148410-0", "The Great Gatsby", new string[] { "F. Scott Fitzgerald" }, new DateTime(1925, 4, 10), 10.99m),
    new Book("978-0-14-028333-4", "To Kill a Mockingbird", new string[] { "Harper Lee" }, new DateTime(1960, 7, 11), 7.99m),
    new Book("978-0-452-28423-4", "1984", new string[] { "George Orwell" }, new DateTime(1949, 6, 8), 8.99m),
    new Book("978-0-7432-7356-5", "The Catcher in the Rye", new string[] { "J.D. Salinger" }, new DateTime(1951, 7, 16), 6.99m)
};


Console.WriteLine("User Defined Delegate:");
LibraryEngine.ProcessBooksUD(books.ToList(), BookFunctions.GetTitle);
LibraryEngine.ProcessBooksUD(books.ToList(), BookFunctions.GetAuthors);
LibraryEngine.ProcessBooksUD(books.ToList(), BookFunctions.GetPrice);
Console.WriteLine("\n\n\n\n\n");


Console.WriteLine("BCL Delegate:");
LibraryEngine.ProcessBooksBCL(books.ToList(), BookFunctions.GetTitle);
LibraryEngine.ProcessBooksBCL(books.ToList(), BookFunctions.GetAuthors);
LibraryEngine.ProcessBooksBCL(books.ToList(), BookFunctions.GetPrice);
Console.WriteLine("\n\n\n\n\n");

Console.WriteLine("Anonymous Method GetISBN");
LibraryEngine.ProcessBooksBCL(books.ToList(), delegate (Book book) { return book.ISBN; });
Console.WriteLine("\n\n\n\n\n");


Console.WriteLine("Lambda Method GetPublicationDate");
LibraryEngine.ProcessBooksBCL(books.ToList(), (book) => book.PublicationDate.ToString());
Console.WriteLine("\n\n\n\n\n");



