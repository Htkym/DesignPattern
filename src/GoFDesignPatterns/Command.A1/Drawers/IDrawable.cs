using System;

namespace Command.A1.Drawers
{
    public interface IDrawable
    {
        void Init();

        void Draw(int x, int y);

        void SetColor(Color color);
    }
}