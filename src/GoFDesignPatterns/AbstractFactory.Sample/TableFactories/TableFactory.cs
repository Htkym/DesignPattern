using AbstractFactory.Sample.Factories;

namespace AbstractFactory.Sample.TableFactories
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