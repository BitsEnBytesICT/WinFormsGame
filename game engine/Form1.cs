using System.Threading;
namespace game_engine
{
    public partial class Form1 : Form
    {
        private int clock;
        private int left;
        private Rectangle rect = new Rectangle(10, 10, 100, 100);
        public Form1()
        {
            InitializeComponent();
        }

        private void FPSCounterTick(object sender, EventArgs e)
        {

            label1.Text = $"FPS: {clock}";
            clock = 0;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red, 10 + left, 10, 100, 100);

            clock += 1;
        }

        private void DrawClockTick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                left += 2;
            }
            else if (e.KeyCode == Keys.A)
            {
                left -= 2;
            }
        }

        private void GameClockTick(object sender, EventArgs e)
        {

        }
    }
}
