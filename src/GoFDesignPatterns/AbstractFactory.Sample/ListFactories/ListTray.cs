using AbstractFactory.Sample.Factories;
using System.Text;

namespace AbstractFactory.Sample.ListFactories
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption)
        {
        }

        public override string MakeHTML()
        {
            var buffer = new StringBuilder();
            buffer.Append("<li>\n");
            buffer.Append($"{Caption}\n");
            buffer.Append("<ul>\n");
            foreach (var item in TrayList)
            {
                buffer.Append(item.MakeHTML());
            }
            buffer.Append("</ul>\n");
            buffer.Append("</li>\n");
            return buffer.ToString();
        }
    }
}