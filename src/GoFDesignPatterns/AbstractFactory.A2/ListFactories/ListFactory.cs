using AbstractFactory.A2.Factories;

namespace AbstractFactory.A2.ListFactories
{
    public class ListFactory : Factory
    {
        public override Link CreateLink(string caption, string url)
             => new ListLink(caption, url);

        public override Tray CreateTray(string caption)
            => new ListTray(caption);

        public override Page CreatePage(string title, string author)
            => new ListPage(title, author);
    }
}