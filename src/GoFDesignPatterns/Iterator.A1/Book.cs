namespace Iterator.A1
{
    public class Book
    {
        public Book(string name)
        {
            _name = name;
        }

        private string _name;

        public string Name
            => _name;
    }
}