namespace Iterator.Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("Around the World in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Daddy-Long-Legs"));

            foreach (var book in bookShelf)
                Console.WriteLine(book.Name);

            Console.WriteLine();

            var books = bookShelf.Where(b => b.Name.Length > 10);
            foreach (var book in books)
                Console.WriteLine(book.Name);

            Console.WriteLine();

            var it = bookShelf.GetEnumerator();
            while (it.MoveNext())
                Console.WriteLine(it.Current.Name);

            it.Dispose();
            Console.WriteLine();

            for (var i = 0; i < bookShelf.Length; i++)
                Console.WriteLine(bookShelf[i].Name);
        }
    }
}