namespace AbstractFactory.Sample.Factories
{
    public abstract class Link : Item
    {
        protected string Url { get; }

        public Link(string caption, string url) : base(caption)
        {
            Url = url;
        }
    }
}