using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using WinFormAnimation;

namespace Animation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OpeningScreen());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        // Helpers
        public static Animator2D animator = new Animator2D();

        public static void AddFontFile(params Control[] controls)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"..\..\Resources\Bushido.ttf");
            for (int i = 0; i < controls.Length; i++)
                controls[i].Font = new Font(pfc.Families[0], controls[i].Font.Size);
        }
        public static void SimpleAnimation2D(float startX, float startY, float endX, float endY, object obj, ulong duration, bool repeat)
        {
            new Animator2D(
                new Path2D(new Float2D(startX, startY), new Float2D(endX, endY), duration)
                .ContinueTo(new Float2D(startX, startY), duration))
            {
                Repeat = repeat
            }
            .Play(obj, Animator2D.KnownProperties.Location);
        }
        public static void Animation2D(float startX, float startY, float endX, float endY, object obj, ulong duration)
        {
            animator.Paths =
                new Path2D(new Float2D(startX, startY), new Float2D(endX, endY), duration).ToArray()
                .ContinueTo(new Float2D(startX, startY), duration);
            animator.Repeat = true;
            animator.Play(obj, Animator2D.KnownProperties.Location, new SafeInvoker(() =>
            {
                animator.Paths = animator.Paths.Last().Reverse().ToArray();
                animator.Play(obj, Animator2D.KnownProperties.Location);
            }));
        }
        public static void OpenForm(Form form, Form new_form)
        {
            form.Hide();
            new_form.Show();
        }
    }
}
