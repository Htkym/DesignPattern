
using Command.A1.Drawers;

namespace Command.A1
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
            redButton = new Button();
            greenButton = new Button();
            blueButton = new Button();
            drawCanvas1 = new DrawCanvas();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Location = new Point(141, 5);
            clearButton.Margin = new Padding(4, 5, 4, 5);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 38);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // redButton
            // 
            redButton.Location = new Point(13, 63);
            redButton.Margin = new Padding(4, 5, 4, 5);
            redButton.Name = "redButton";
            redButton.Size = new Size(100, 38);
            redButton.TabIndex = 3;
            redButton.Text = "Red";
            redButton.UseVisualStyleBackColor = true;
            redButton.Click += RedButton_Click;
            // 
            // greenButton
            // 
            greenButton.Location = new Point(141, 63);
            greenButton.Margin = new Padding(4, 5, 4, 5);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(100, 38);
            greenButton.TabIndex = 4;
            greenButton.Text = "Green";
            greenButton.UseVisualStyleBackColor = true;
            greenButton.Click += GreenButton_Click;
            // 
            // blueButton
            // 
            blueButton.Location = new Point(269, 63);
            blueButton.Margin = new Padding(4, 5, 4, 5);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(100, 38);
            blueButton.TabIndex = 5;
            blueButton.Text = "Blue";
            blueButton.UseVisualStyleBackColor = true;
            blueButton.Click += BlueButton_Click;
            // 
            // drawCanvas1
            // 
            drawCanvas1.Location = new Point(13, 111);
            drawCanvas1.Margin = new Padding(4, 5, 4, 5);
            drawCanvas1.Name = "drawCanvas1";
            drawCanvas1.Size = new Size(356, 312);
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
            Controls.Add(drawCanvas1);
            Controls.Add(blueButton);
            Controls.Add(greenButton);
            Controls.Add(redButton);
            Controls.Add(clearButton);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Command Pattern Sample";
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clearButton;
        private Button redButton;
        private Button greenButton;
        private Button blueButton;
        private DrawCanvas drawCanvas1;
    }
}

