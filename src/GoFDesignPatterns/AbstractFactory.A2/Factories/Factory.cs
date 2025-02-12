namespace AbstractFactory.A2.Factories
{
    public abstract class Factory
    {
        public static Factory? GetFactory(string classname)
        {
            Factory? factory = null;
            try
            {
                factory = (Factory?)Activator.CreateInstance(Type.GetType(classname) ?? throw new TypeLoadException());
            }
            catch (TypeLoadException)
            {
                Console.WriteLine("Class " + classname + " is not found.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return factory;
        }

        public abstract Link CreateLink(string caption, string url);

        public abstract Tray CreateTray(string caption);

        public abstract Page CreatePage(string title, string author);

        public Page CreateYahooPage()
        {
            var link = CreateLink("Yahoo!", "http://www.yahoo.com/");
            var page = CreatePage("Yahoo!", "Yahoo!");
            page.Add(link);
            return page;
        }
    }
}