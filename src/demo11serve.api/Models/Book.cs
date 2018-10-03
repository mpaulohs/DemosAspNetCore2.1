using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo11serve.api.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public Book(string title, string author, DateTime date)
        {
            Title = title;
            Author = author;
            Date = date;
        }

        public override string ToString()
        {
            return String.Format("Title : {0}\nAuthor : {1}\nPublished : {2}", Title, Author, Date.Year);
        }
    }
}
