using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    internal class Book : IComparable<Book>
    {
        private string title;
        private string author;
        private string isbn;

        // Constructors
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }

        // Properties
        public string Title
        {
            // get - returns the variable
            get { return this.title; }
            // set - assigns the value to the variable
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public string Isbn
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }

        // Override the result/name for 'object.ToString()'
        public override string ToString()
        {
            return "Book:\n  Title: " + title + "\n  Author: " + author + "\n  ISBN: " + isbn + "\n";
        }

        public int CompareTo(Book? book)
        {
            // Generic comparison (isbn, title or author)
            return isbn.CompareTo(book!.isbn);
        }
    }
}
