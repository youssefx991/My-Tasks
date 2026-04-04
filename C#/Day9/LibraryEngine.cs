using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    public delegate string BookDelegate(Book book);
    public class LibraryEngine
    {
        public static void ProcessBooksUD(List<Book> bList, BookDelegate fPtr)
        {
            foreach (Book book in bList)
            {
                Console.WriteLine(fPtr(book));
                Console.WriteLine("-------------------------------------------------------------------\n");
            }
        }
        public static void ProcessBooksBCL(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book book in bList)
            {
                Console.WriteLine(fPtr(book));
                Console.WriteLine("-------------------------------------------------------------------\n");
            }
        }
    }
}
