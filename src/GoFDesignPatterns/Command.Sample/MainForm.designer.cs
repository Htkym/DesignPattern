
using Command.Sample.Drawers;

namespace Command.Sample
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        private void InitializeComponent()
        {
            clearButton = new Button();
            drawCanvas1 = new DrawCanvas();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Location = new Point(116, 2);
            clearButton.Margin = new Padding(4, 5, 4, 5);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 38);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // drawCanvas1
            // 
            drawCanvas1.BackColor = SystemColors.Window;
            drawCanvas1.Location = new Point(1, 53);
            drawCanvas1.Margin = new Padding(5, 8, 5, 8);
            drawCanvas1.Name = "drawCanvas1";
            drawCanvas1.Size = new Size(387, 398);
            drawCanvas1.TabIndex = 0;
            drawCanvas1.MouseDown += DrawCanvas1_MouseDown;
            drawCanvas1.MouseMove += DrawCanvas1_MouseMove;
            drawCanvas1.MouseUp += DrawCanvas1_MouseUp;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 455);
            Controls.Add(clearButton);
            Controls.Add(drawCanvas1);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Command Pattern Sample";
            ResumeLayout(false);

        }

        #endregion

        private DrawCanvas drawCanvas1;
        private System.Windows.Forms.Button clearButton;
    }
}

