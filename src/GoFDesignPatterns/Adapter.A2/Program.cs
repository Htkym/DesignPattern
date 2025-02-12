namespace Adapter.A2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var f = new FileProperties();
            try
            {
                f.ReadFromFile("file.txt");
                f.SetValue("year", "2004");
                f.SetValue("month", "4");
                f.SetValue("day", "21");
                f.WriteToFile("newfile.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}