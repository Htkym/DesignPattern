using System.Text;

namespace Builder.A2
{
    public class TextBuilder : Builder
    {
        private StringBuilder _buffer = new();

        protected override void BuildTitle(string title)
        {
            _buffer.Append("==============================\n");
            _buffer.Append($"[{title}]\n");
            _buffer.Append("\n");
        }

        protected override void BuildString(string str)
        {
            _buffer.Append($"■{str}\n");
            _buffer.Append("\n");
        }

        protected override void BuildItems(string[] items)
        {
            foreach (var item in items)
            {
                _buffer.Append($" ・{item}\n");
            }
            _buffer.Append("\n");
        }

        protected override void BuildDone()
        {
            _buffer.Append("==============================\n");
        }

        public string GetResult()
        {
            return _buffer.ToString();
        }
    }
}