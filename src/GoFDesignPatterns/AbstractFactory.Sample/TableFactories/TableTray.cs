using AbstractFactory.Sample.Factories;
using System.Text;

namespace AbstractFactory.Sample.TableFactories
{
    public class TableTray : Tray
    {
        public TableTray(string caption) : base(caption)
        {
        }

        public override string MakeHTML()
        {
            var buffer = new StringBuilder();
            buffer.Append("<td>");
            buffer.Append("<table width=\"100%\" border=\"1\"><tr>");
            buffer.Append($"<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"{TrayList.Count}\"><b>{Caption}</b></td>");
            buffer.Append("</tr>\n");
            buffer.Append("<tr>\n");
            foreach (var trayItem in TrayList)
            {
                buffer.Append(trayItem.MakeHTML());
            }
            buffer.Append("</tr></table>");
            buffer.Append("</td>");
            return buffer.ToString();
        }
    }

    {
    }
}