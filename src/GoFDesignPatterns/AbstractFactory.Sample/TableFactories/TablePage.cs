using AbstractFactory.Sample.Factories;
using System.Text;

namespace AbstractFactory.Sample.TableFactories
{
    public class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHTML()
        {
            var buffer = new StringBuilder();
            buffer.Append($"<html><head><title>{Title}</title></head>\n");
            buffer.Append("<body>\n");
            buffer.Append($"<h1>{Title}</h1>\n");
            buffer.Append("<table width=\"80%\" border=\"3\">\n");
            foreach (var item in Content) buffer.Append($"<tr>{item.MakeHTML()}</tr>");
            buffer.Append("</table>\n");
            buffer.Append($"<hr><address>{Author}</address>");
            buffer.Append("</body></html>\n");
            return buffer.ToString();
        }
    }
}