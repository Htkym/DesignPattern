namespace AbstractFactory.Sample.Factories
{
    public abstract class Page
    {
        protected string Title { get; }

        protected string Author { get; }

        protected List<Item> Content { get; } = [];

        public Page(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Add(Item item)
            => Content.Add(item);

        public void Output()
        {
            try
            {
                string filename = Title + ".html";
                using (var writer = new StreamWriter(filename))
                {
                    writer.Write(MakeHTML());
                }
                Console.WriteLine(filename + " is created.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public abstract string MakeHTML();
    }
}