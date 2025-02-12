namespace Builder.A3.WinForm
{
    public class FrameBuilder : Builder
    {
        private readonly Form frame = new();
        private readonly FlowLayoutPanel box = new() { FlowDirection = FlowDirection.TopDown };

        public override void MakeTitle(string title)
        {
            frame.Text = title;
        }

        public override void MakeString(string str)
        {
            Label label = new() { Text = str };
            box.Controls.Add(label);
        }

        public override void MakeItems(string[] items)
        {
            FlowLayoutPanel innerBox = new() { FlowDirection = FlowDirection.TopDown };
            foreach (var item in items)
            {
                Button button = new() { Text = item };
                button.Click += new EventHandler(ActionPerformed);
                innerBox.Controls.Add(button);
            }
            box.Controls.Add(innerBox);
        }

        public override void Close()
        {
            frame.Controls.Add(box);
            frame.AutoSize = true;
            frame.FormClosing += (sender, e) => { Application.Exit(); };
            Application.Run(frame);
        }

        public Form GetResult()
        {
            return frame;
        }

        private void ActionPerformed(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                Console.WriteLine(button.Text);
            }
        }
    }
}