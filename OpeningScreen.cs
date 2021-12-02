using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Animation
{
    public partial class OpeningScreen : Form
    {
        public OpeningScreen()
        {
            InitializeComponent();
        }

        private void OpeningScreen_Load(object sender, System.EventArgs e)
        {
            Program.AddFontFile(startBtn, creditsLbl);
        }

        private void Start(object sender, System.EventArgs e)
        {
            Program.OpenForm(this, new Animation());
        }

        private void StartBtn_MouseEnter(object sender, System.EventArgs e)
        {
            startBtn.BackColor = Color.CadetBlue;
        }
        private void StartBtn_MouseLeave(object sender, System.EventArgs e)
        {
            startBtn.BackColor = Color.Transparent;
        }
    }
}
