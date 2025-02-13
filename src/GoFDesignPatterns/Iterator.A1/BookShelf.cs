namespace Iterator.A1
{
    public class BookShelf : IEnumerable<Book>
    {
        private List<Book> Books { get; }

        public BookShelf(int intial)
        {
            Books = new List<Book>(intial);
        }

        public int Length => Books.Count;

        public Book this[int index] => Books[index];

        public void AppendBook(Book book) 
            => Books.Add(book);

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in Books)
            {
                yield return book;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}