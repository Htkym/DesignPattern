namespace ChainOfResponsibility.Sample
{
    public class Trouble
    {
        private readonly int _number;

        public Trouble(int number)
        {
            _number = number;
        }

        public int GetNumber()
        {
            return _number;
        }

        public override string ToString()
        {
            return $"[Trouble {_number}]";
        }
    }
}