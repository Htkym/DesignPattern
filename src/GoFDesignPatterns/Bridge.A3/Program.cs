namespace Bridge.A3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var d1 = new IncreaseDisplay(new CharDisplayImpl('<', '*', '>'), 1);
            var d2 = new IncreaseDisplay(new CharDisplayImpl('|', '#', '-'), 2);

            d1.IncreaseDisplayTimes(4);
            d2.IncreaseDisplayTimes(6);
        }
    }
}