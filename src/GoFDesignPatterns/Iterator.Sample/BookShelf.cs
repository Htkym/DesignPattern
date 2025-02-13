using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Sample
{
    public class BookShelf : IEnumerable<Book>
    {
        private Book[] Books { get; }
        private int last = 0;

        public BookShelf(int maxSize)
        {
            Books = new Book[maxSize];
        }

        public int Length => last;

        public Book this[int index] => Books[index];

        public void AppendBook(Book book)
        {
            Books[last] = book;
            last++;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < last; i++)
            {
                yield return Books[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}