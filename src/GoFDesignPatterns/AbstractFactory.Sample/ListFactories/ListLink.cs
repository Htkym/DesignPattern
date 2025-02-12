using AbstractFactory.Sample.Factories;

namespace AbstractFactory.Sample.ListFactories
{
    public class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHTML()
            => $"<li><a href=\"{Url}\">{Caption}</a></li>\n";
    }
}