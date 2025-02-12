namespace Builder.A2
{
    public abstract class Builder
    {
        private bool initialized = false;

        public void MakeTitle(string title)
        {
            if (!initialized)
            {
                BuildTitle(title);
                initialized = true;
            }
        }

        public void MakeString(string str)
        {
            if (initialized)
                BuildString(str);
        }

        public void MakeItems(string[] items)
        {
            if (initialized)
                BuildItems(items);
        }

        public void Close()
        {
            if (initialized)
                BuildDone();
        }

        protected abstract void BuildTitle(string title);

        protected abstract void BuildString(string str);

        protected abstract void BuildItems(string[] items);

        protected abstract void BuildDone();
    }
}