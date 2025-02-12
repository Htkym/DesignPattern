namespace Bridge.A3
{
    public class IncreaseDisplay : CountDisplay
    {
        private readonly int _step;

        public IncreaseDisplay(DisplayImpl impl, int step) : base(impl)
        {
            _step = step;
        }

        public void IncreaseDisplayTimes(int level)
        {
            int count = 0;
            for (int i = 0; i < level; i++)
            {
                MultiDisplay(count);
                count += _step;
            }
        }
    }
}