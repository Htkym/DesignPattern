using System.Text;

namespace Builder.A2
{
    public class HTMLBuilder : Builder
    {
        private string _filename = string.Empty;

        private readonly StringBuilder _buffer = new();

        protected override void BuildTitle(string title)
        {
            _filename = title + ".html";
            _buffer.Append($"<html><head><title>{title}</title></head><body>\n");
            _buffer.Append($"<h1>{title}</h1>\n");
        }

        protected override void BuildString(string str)
        {
            _buffer.Append($"<p>{str}</p>\n");
        }

        protected override void BuildItems(string[] items)
        {
            _buffer.Append("<ul>\n");
            foreach (var item in items)
            {
                _buffer.Append($"<li>{item}</li>\n");
            }
            _buffer.Append("</ul>\n");
        }

        protected override void BuildDone()
        {
            _buffer.Append("</body></html>\n");
        }

        public string GetResult()
        {
            return _buffer.ToString();
        }

        public string GetFilename()
        {
            return _filename;
        }
    }
}