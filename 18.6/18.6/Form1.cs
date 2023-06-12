namespace _18._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void forog_Click(object sender, EventArgs e)
        {
            Image s = smile6.Image;
            smile6.Image = smile5.Image;
            smile5.Image = smile4.Image;
            smile4.Image = smile3.Image;
            smile3.Image = smile2.Image;
            smile2.Image = smile1.Image;
            smile1.Image = s;
        }

        private void forog2_Click(object sender, EventArgs e)
        {
            Image s = smile1.Image;
            smile1.Image = smile2.Image;
            smile2.Image = smile3.Image;
            smile3.Image = smile4.Image;
            smile4.Image = smile5.Image;
            smile5.Image = smile6.Image;
            smile6.Image = s;
        }
    }
}