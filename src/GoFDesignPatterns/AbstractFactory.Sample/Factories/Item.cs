namespace AbstractFactory.Sample.Factories
{
    public abstract class Item
    {
        protected string Caption { get; }

        public Item(string caption)
        {
            Caption = caption;
        }

        public abstract string MakeHTML();
    }
}