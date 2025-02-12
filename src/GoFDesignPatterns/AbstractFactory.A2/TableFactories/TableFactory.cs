using AbstractFactory.A2.Factories;

namespace AbstractFactory.A2.TableFactories
{
    public class TableFactory : Factory
    {
        public override Link CreateLink(string caption, string url)
            => new TableLink(caption, url);

        public override Tray CreateTray(string caption)
            => new TableTray(caption);

        public override Page CreatePage(string title, string author)
            => new TablePage(title, author);
    }
}