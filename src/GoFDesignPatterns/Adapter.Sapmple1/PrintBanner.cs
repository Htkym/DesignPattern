namespace Adapter.Sapmple1
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string text) : base(text)
        {
        }

        public void PrintWeak()
        {
            ShowWithParen();
        }

        public void PrintStrong()
        {
            ShowWithAster();
        }
    }
}