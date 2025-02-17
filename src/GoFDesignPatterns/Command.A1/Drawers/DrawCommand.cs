using Command.A1.Commands;

namespace Command.A1.Drawers
{
    public class DrawCommand : ICommand
    {
        protected internal IDrawable drawable;

        private Point position;

        public DrawCommand(IDrawable drawable, Point position)
        {
            this.drawable = drawable;
            this.position = position;
        }

        public virtual void Execute()
        {
            drawable.Draw(position.X, position.Y);
        }
    }
}