using Tyuiu.KulkoDA.Sprint6.Task7.V13.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task7.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonOpen_KDA_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_KDA_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_KDA_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        
    }
}
