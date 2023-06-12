namespace ugrik
{
    public partial class Formugras : Form
    {
        public Formugras()
        {
            InitializeComponent();
        }

        private void btnBalrafel_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void btnjobbrafel_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = 0;
        }

        private void btnBalrale_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void btnJobbrale_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }
    }
}