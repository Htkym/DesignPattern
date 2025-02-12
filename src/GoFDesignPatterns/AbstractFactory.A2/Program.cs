using AbstractFactory.A2.Factories;
using AbstractFactory.A2.ListFactories;

namespace AbstractFactory.A2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var name = nameof(ListFactory); // mameof(TableFactory);

            var factory = Factory.GetFactory(name) ?? throw new InvalidOperationException();
            var page = factory.CreateYahooPage();
            page.Output();
        }
    }
}