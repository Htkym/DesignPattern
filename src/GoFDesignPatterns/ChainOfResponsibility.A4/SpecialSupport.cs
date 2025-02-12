namespace ChainOfResponsibility.A4
{
    public class SpecialSupport : Support
    {
        private readonly int _number;

        public SpecialSupport(string name, int number) : base(name)
        {
            _number = number;
        }

        protected override bool Resolve(Trouble trouble)
        {
            return trouble.GetNumber() == _number;
        }
    }
}