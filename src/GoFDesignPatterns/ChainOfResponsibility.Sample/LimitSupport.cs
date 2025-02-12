namespace ChainOfResponsibility.Sample
{
    public class LimitSupport : Support
    {
        private readonly int _limit;

        public LimitSupport(string name, int limit) : base(name)
        {
            _limit = limit;
        }

        protected override bool Resolve(Trouble trouble)
        {
            return trouble.GetNumber() < _limit;
        }
    }
}