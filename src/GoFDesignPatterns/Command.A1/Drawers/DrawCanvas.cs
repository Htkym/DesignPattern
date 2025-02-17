using Command.A1.Commands;

namespace Command.A1.Drawers
{
    public partial class DrawCanvas : UserControl, IDrawable
    {
        public DrawCanvas()
        {
            InitializeComponent();
            Init();
        }

        // 描画色
        private Color _color;

        // 描画する点の半径
        private int _radius;

        // 履歴
        private MacroCommand _history = default!;

        public void Init()
        {
            _color = Color.Red;
            _radius = 6;
        }

        public void Draw(int x, int y)
        {
            using var g = CreateGraphics();
            using var brush = new SolidBrush(_color);
            g.FillEllipse(brush, x - _radius, y - _radius, _radius * 2, _radius * 2);
        }

        public void SetColor(Color color)
        {
            _color = color;
        }

        public void SetHistory(MacroCommand history)
        {
            _history = history;
        }

        private void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            _history?.Execute();
        }
    }
}