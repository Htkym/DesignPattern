namespace Bridge.A2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var d = new CountDisplay(new StringDisplayImpl("ster.txt"));
            d.MultiDisplay(3);
        }
    }
}