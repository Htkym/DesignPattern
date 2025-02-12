namespace Bridge.Sample
{
    public class StringDisplayImpl : DisplayImpl
    {
        private readonly string _string;
        private readonly int _width;

        public StringDisplayImpl(string @string)
        {
            _string = @string;
            _width = @string.Length;
        }

        public override void RawOpen()
            => PrintLine();

        public override void RawPrint()
            => Console.WriteLine($"|{_string}|");

        public override void RawClose()
            => PrintLine();

        private void PrintLine()
        {
            Console.Write("+");
            for (var i = 0; i < _width; i++) Console.Write("-");
            Console.WriteLine("+");
        }
    }
}