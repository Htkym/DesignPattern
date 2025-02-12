namespace Bridge.A3
{
    public class RandomCountDisplay : CountDisplay
    {
        private readonly Random _random = new();

        public RandomCountDisplay(DisplayImpl impl) : base(impl)
        {
        }

        public void RandomDisplay(int times)
            => MultiDisplay(_random.Next(times));
    }
}