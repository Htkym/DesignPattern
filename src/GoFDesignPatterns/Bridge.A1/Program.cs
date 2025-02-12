namespace Bridge.A1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var d = new RandomCountDisplay(new StringDisplayImpl("Hello, Japan."));
            d.MultiDisplay(10);
        }
    }
}