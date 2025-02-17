using Command.A1.Commands;
using Command.A1.Drawers;

namespace Command.A1;

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

    private void RedButton_Click(object sender, EventArgs e)
    {
        var cmd = new ColorCommand(drawCanvas1, Color.Red);
        commands.Append(cmd);
        cmd.Execute();
    }
    private void GreenButton_Click(object sender, EventArgs e)
    {
        var cmd = new ColorCommand(drawCanvas1, Color.Green);
        commands.Append(cmd);
        cmd.Execute();
    }
    private void BlueButton_Click(object sender, EventArgs e)
    {
        var cmd = new ColorCommand(drawCanvas1, Color.Blue);
        commands.Append(cmd);
        cmd.Execute();
    }
}