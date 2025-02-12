namespace Adapter.Sapmple1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();
        }
    }
}