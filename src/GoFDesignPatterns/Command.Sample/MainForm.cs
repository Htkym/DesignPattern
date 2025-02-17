using Command.Sample.Commands;
using Command.Sample.Drawers;

namespace Command.Sample;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        drawCanvas1.SetHistory(commands);
    }

    private MacroCommand commands = new MacroCommand();

    private bool drag = false;

    private void DrawCanvas1_MouseDown(object sender, MouseEventArgs e)
    {
        drag = true;
    }

    private void DrawCanvas1_MouseMove(object sender, MouseEventArgs e)
    {
        if (drag)
        {
            ICommand cmd = new DrawCommand(drawCanvas1, e.Location);
            commands.Append(cmd);
            cmd.Execute();
        }
    }

    private void DrawCanvas1_MouseUp(object sender, MouseEventArgs e)
    {
        drag = false;
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        commands.Clear();
        drawCanvas1.Invalidate();
    }
}