namespace Bridge.A3
{
    public class CharDisplayImpl : DisplayImpl
    {
        private readonly char _head;
        private readonly char _body;
        private readonly char _foot;

        public CharDisplayImpl(char head, char body, char foot)
        {
            _head = head;
            _body = body;
            _foot = foot;
        }

        public override void RawOpen()
        {
            Console.Write(_head);
        }

        public override void RawPrint()
        {
            Console.Write(_body);
        }

        public override void RawClose()
        {
            Console.WriteLine(_foot);
        }
    }
}