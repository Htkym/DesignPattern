using AbstractFactory.Sample.Factories;
using AbstractFactory.Sample.ListFactories;

namespace AbstractFactory.Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var name = nameof(ListFactory); // mameof(TableFactory);

            var factory = Factory.GetFactory(name) ?? throw new InvalidOperationException();

            var asahi = factory.CreateLink("朝日新聞", "http://www.asahi.com/");
            var yomiuri = factory.CreateLink("読売新聞", "http://www.yomiuri.co.jp/");

            var us_yahoo = factory.CreateLink("Yahoo!", "http://www.yahoo.com/");
            var jp_yahoo = factory.CreateLink("Yahoo!Japan", "http://www.yahoo.co.jp/");
            var excite = factory.CreateLink("Excite", "http://www.excite.com/");
            var google = factory.CreateLink("Google", "http://www.google.com/");

            var trayNews = factory.CreateTray("新聞");
            trayNews.Add(asahi);
            trayNews.Add(yomiuri);

            var trayYahoo = factory.CreateTray("Yahoo!");
            trayYahoo.Add(us_yahoo);
            trayYahoo.Add(jp_yahoo);

            var traySearch = factory.CreateTray("サーチエンジン");
            traySearch.Add(trayYahoo);
            traySearch.Add(excite);
            traySearch.Add(google);

            var page = factory.CreatePage("LinkPage", "結城 浩");
            page.Add(trayNews);
            page.Add(traySearch);
            page.Output();
        }
    }
}