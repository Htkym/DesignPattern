﻿namespace Builder.A3.WinForm
{
    public abstract class Builder
    {
        public abstract void MakeTitle(string title);

        public abstract void MakeString(string str);

        public abstract void MakeItems(string[] items);

        public abstract void Close();
    }
}