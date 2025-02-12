using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.A3
{
    public class Director
    {
        private readonly Builder _builder;
        public Director(Builder builder)
        {
            _builder = builder;
        }
        public void Construct()
        {
            _builder.MakeTitle("Greeting");
            _builder.MakeString("朝から昼にかけて");
            _builder.MakeItems(["おはようございます。", "こんにちは。"]);
            _builder.MakeString("夜に");
            _builder.MakeItems(["こんばんは。", "おやすみなさい。", "さようなら。"]);
            _builder.Close();
        }
    }
}
