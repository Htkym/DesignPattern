﻿using AbstractFactory.Sample.Factories;

namespace AbstractFactory.Sample.TableFactories
{
    public class TableLink : Link
    {
        public TableLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHTML()
        {
            return $"<td><a href=\"{Url}\">{Caption}</a></td>\n";
        }
    }
}