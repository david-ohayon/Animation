using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Right : Form
    {
        public Right()
        {
            InitializeComponent();
        }
        private void Right_Load(object sender, EventArgs e)
        {
            Program.AddFontFile(GoLeftBtn);

            Program.Animation2D(kiki.Location.X, kiki.Location.Y, kiki.Location.X, kiki.Location.Y + 15, kiki, 2000);
        }

        // directions
        private async void GoLeft(object sender, System.EventArgs e)
        {
            Program.animator.Stop();
            GoLeftBtn.Visible = false;
            Program.SimpleAnimation2D(kiki.Location.X, kiki.Location.Y, kiki.Location.X / 2, kiki.Location.Y, kiki, 25 * 1000, false);
            await Task.Delay(25 * 1000);
            Program.OpenForm(this, new Animation());
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
    }
}
