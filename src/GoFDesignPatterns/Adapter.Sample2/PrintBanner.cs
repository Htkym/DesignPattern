namespace Adapter.Sample2
{
    public class PrintBanner : IPrint
    {
        private readonly Banner banner;

        public PrintBanner(string text)
        {
            banner = new Banner(text);
        }

        public void PrintWeak()
        {
            banner.ShowWithParen();
        }

        public void PrintStrong()
        {
            banner.ShowWithAster();
        }
    }
}