using System.Text;

namespace Builder.A4
{
    public class HTMLBuilder : Builder
    {
        private string _filename = string.Empty;
        private readonly StringBuilder _buffer = new();

        public override void MakeTitle(string title)
        {
            _filename = title + ".html";
            _buffer.Append($"<html><head><title>{title}</title></head><body>\n");
            _buffer.Append($"<h1>{title}</h1>\n");
        }

        public override void MakeString(string str)
        {
            _buffer.Append($"<p>{str}</p>\n");
        }

        public override void MakeItems(string[] items)
        {
            _buffer.Append("<ul>\n");
            foreach (var item in items)
            {
                _buffer.Append($"<li>{item}</li>\n");
            }
            _buffer.Append("</ul>\n");
        }

        public override void Close()
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