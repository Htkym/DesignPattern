using AbstractFactory.A2.Factories;
using System.Text;

namespace AbstractFactory.A2.ListFactories
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHTML()
        {
            var buffer = new StringBuilder();
            buffer.Append($"<html><head><title>{Title}</title></head>\n");
            buffer.Append("<body>\n");
            buffer.Append($"<h1>{Title}</h1>\n");
            buffer.Append("<ul>\n");
            foreach (var item in Content) buffer.Append(item.MakeHTML());
            buffer.Append("</ul>\n");
            buffer.Append($"<hr><address>{Author}</address>");
            buffer.Append("</body></html>\n");
            return buffer.ToString();
        }
    }
}