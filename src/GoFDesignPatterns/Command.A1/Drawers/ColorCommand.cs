using Command.A1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.A1.Drawers
{
    public class ColorCommand : ICommand
    {
        protected IDrawable _drawable;

        private Color _color;

        public ColorCommand(IDrawable drawable, Color color)
        {
            _drawable = drawable;
            _color = color;
        }

        public void Execute()
        {
            _drawable.SetColor(_color);
        }
    }
}
