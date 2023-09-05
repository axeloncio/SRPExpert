using System;

namespace SRP
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Code { get; }

        public Book(string title, string author, string code)
        {
            Title = title;
            Author = author;
            Code = code;
        }
    }

    public class LibraryBookManager
    {
        public void ShelveBook(Book book, string sector, string shelve)
        {
            // Lógica para ubicar el libro en la biblioteca
            book.LibrarySector = sector;
            book.LibraryShelve = shelve;
        }
    }
}