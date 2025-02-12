namespace AbstractFactory.Sample.Factories
{
    public abstract class Tray : Item
    {
        protected List<Item> TrayList { get; } = [];

        public Tray(string caption) : base(caption)
        {
        }

        public void Add(Item item)
            => TrayList.Add(item);
    }
}