namespace _18._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int meretezo = (12 / 10);
        private void felcsökken_Click(object sender, EventArgs e)
        {
                Width -= meretezo; 
                Height -= meretezo;
        }

        private void lecsökken_Click(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
                Opacity += 0.1;
        }

        private void Kozepre_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Le.Visible = TelL.Visible =
            Fel.Visible = TelF.Visible =
            Bal.Visible =TelB.Visible =
            Jobb.Visible = TelJ.Visible = true;
        }

        private void Fel_Click(object sender, EventArgs e)
        {
            if (Top - meretezo > 0) 
            { Top -= meretezo; } 
            else { Top = 0; Fel.Visible = TelF.Visible = false; }
            Le.Visible = TelL.Visible = true;
        }

        private void TelF_Click(object sender, EventArgs e)
        {
            Top = 0;
            Fel.Visible =TelF.Visible = false; 
            Le.Visible = TelL.Visible = true;
        }

        private void Le_Click(object sender, EventArgs e)
        {
            if (Top - meretezo < 0)
            { Top -= meretezo; }
            else { Top = 0; Le.Visible = TelL.Visible = false; }
            Le.Visible = TelL.Visible = true;
        }

        private void TelL_Click(object sender, EventArgs e)
        {
            Top= (Screen.PrimaryScreen.Bounds.Height - Height) * 2;
            Le.Visible = TelL.Visible = true;
            Fel.Visible = TelF.Visible = false;
        }

        private void TelB_Click(object sender, EventArgs e)
        {
            Left = 0;
            Bal.Visible = TelB.Visible = false;
            Jobb.Visible = TelJ.Visible = true;
        }

        private void TelJ_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Height - Height) * 2;
            Bal.Visible = TelB.Visible = false;
            Jobb.Visible = TelJ.Visible = true;
        }


        private void Bal_Click(object sender, EventArgs e)
        {
            if (Left - meretezo < 0)
            { Left -= meretezo; }
            else { Left = 0; Bal.Visible = TelB.Visible = false; }
            Bal.Visible = TelB.Visible = true;
        }
    }
}