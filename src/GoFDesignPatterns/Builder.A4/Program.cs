namespace Builder.A4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Usage();
                return;
            }

            if (args[0] == "plain")
            {
                var textBuilder = new TextBuilder();
                var director = new Director(textBuilder);
                director.Construct();
                var result = textBuilder.GetResult();
                Console.WriteLine(result);
            }
            else if (args[0] == "html")
            {
                var htmlBuilder = new HTMLBuilder();
                var director = new Director(htmlBuilder);
                director.Construct();
                var filename = htmlBuilder.GetFilename();
                Console.WriteLine($"{filename}が作成されました。");
            }
            else
            {
                Usage();
                return;
            }
        }

        private static void Usage()
        {
            Console.WriteLine("Usage: dotnet run plain プレーンテキストで文書作成");
            Console.WriteLine("Usage: dotnet run html  HTMLファイルで文書作成");
        }
    }
}