namespace Bridge.Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImpl("Hello, Japan."));
            Display d2 = new CountDisplay(new StringDisplayImpl("Hello, World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));

            d1.DisplayMethod();
            d2.DisplayMethod();
            d3.DisplayMethod();
            d3.MultiDisplay(5);
        }
    }
}