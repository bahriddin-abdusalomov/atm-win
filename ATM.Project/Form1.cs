using ATM.Project.Forms;

namespace ATM.Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUz_Click(object sender, EventArgs e)
        {
            UzPage uzPage = new UzPage();
            uzPage.ShowDialog();
        }
    }
}
