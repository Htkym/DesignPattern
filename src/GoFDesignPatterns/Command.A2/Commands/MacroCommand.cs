namespace Command.A2.Commands
{
    public class MacroCommand : ICommand
    {
        private Stack<ICommand> commands = new Stack<ICommand>();

        public void Execute()
        {
            commands.ForEach(x => x.Execute());
        }

        public void Append(ICommand command)
        {
            if (command != this)
                commands.Push(command);
        }

        public void Undo()
        {
            if (commands.Count != 0)
                commands.Pop();
        }

        public void Clear()
        {
            commands.Clear();
        }
    }
}