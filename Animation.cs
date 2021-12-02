using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAnimation;

namespace Animation
{
    public partial class Animation : Form
    {
        public Animation()
        {
            InitializeComponent();
        }
        private async void Animation_Load(object sender, System.EventArgs e)
        {
            Program.AddFontFile(GoLeftBtn, GoRightBtn);

            Program.Animation2D(kiki.Location.X, kiki.Location.Y, kiki.Location.X, kiki.Location.Y + 15, kiki, 2000);

            for (int i = 1; i <= 4; i++)
            {
                Control control = form_panel.Controls[$"cloud_{i}"];
                await Task.Delay(100);
                Program.SimpleAnimation2D(control.Location.X, control.Location.Y, control.Location.X + 15, control.Location.Y, control, 3250, true);
            }
        }

        private void OverlappingImages(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.moon, 12, 25);
            e.Graphics.DrawImage(Properties.Resources.cloud_5, 0, 60);
        }

        // directions
        private async void GoLeft(object sender, System.EventArgs e)
        {
            Program.animator.Stop();
            GoLeftBtn.Visible = false;
            GoRightBtn.Visible = false;
            Program.SimpleAnimation2D(kiki.Location.X, kiki.Location.Y, kiki.Location.X / 2, kiki.Location.Y, kiki, 25 * 1000, false);
            await Task.Delay(25 * 1000);
            Program.OpenForm(this, new Left());
        }
        private void GoLeftBtn_MouseEnter(object sender, System.EventArgs e)
        {
            Program.AddFontFile(GoLeftBtn);
            GoLeftBtn.BackColor = Color.Black;
        }
        private void GoLeftBtn_MouseLeave(object sender, System.EventArgs e)
        {
            Program.AddFontFile(GoLeftBtn);
            GoLeftBtn.BackColor = Color.Transparent;
        }

        private async void GoRight(object sender, System.EventArgs e)
        {
            Program.animator.Stop();
            GoLeftBtn.Visible = false;
            GoRightBtn.Visible = false;
            Program.SimpleAnimation2D(kiki.Location.X, kiki.Location.Y, kiki.Location.X * 2, kiki.Location.Y, kiki, 25 * 1000, false);
            await Task.Delay(25 * 1000);
            Program.OpenForm(this, new Right());
        }
        private void GoRightBtn_MouseEnter(object sender, System.EventArgs e)
        {
            Program.AddFontFile(GoRightBtn);
            GoRightBtn.BackColor = Color.Black;
        }
        private void GoRightBtn_MouseLeave(object sender, System.EventArgs e)
        {
            Program.AddFontFile(GoRightBtn);
            GoRightBtn.BackColor = Color.Transparent;
        }
    }
}
