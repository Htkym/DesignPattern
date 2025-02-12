using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Windows.Forms;

namespace Builder.A3
{
    public class FrameBuilder
    {
        private Form frame = new Form();
        private FlowLayoutPanel box = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown };

        public void MakeTitle(string title)
        {
            frame.Text = title;
        }

        public void MakeString(string str)
        {
            Label label = new Label { Text = str };
            box.Controls.Add(label);
        }

        public void MakeItems(string[] items)
        {
            FlowLayoutPanel innerBox = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown };
            foreach (var item in items)
            {
                Button button = new Button { Text = item };
                button.Click += new EventHandler(ActionPerformed);
                innerBox.Controls.Add(button);
            }
            box.Controls.Add(innerBox);
        }

        public void Close()
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

        private void ActionPerformed(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                Console.WriteLine(button.Text);
            }
        }
    }
}
