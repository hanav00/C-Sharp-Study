namespace CuteCat
{
    public partial class Form1 : Form
    {
        private Cat MyCat = new Cat("Lucas", 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MyCat.Play();
            CatScreen.Text = MyCat.Express();
        }

        private void Feed_Click(object sender, EventArgs e)
        {
            MyCat.Feed();
            CatScreen.Text = MyCat.Express();
        }

        private void CatTimer_Tick(object sender, EventArgs e)
        {
            MyCat.Bored();
            CatScreen.Text = MyCat.Express();
        }
    }
}