using Tyuiu.KulkoDA.Sprint6.Task6.V8.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonHelp_KDA_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void buttonDone_KDA_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOut_KDA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpen_KDA_Click(object sender, EventArgs e)
        {
            openFileDialog_KDA.ShowDialog();
            openFilePath = openFileDialog_KDA.FileName;
            textBoxIn_KDA.Text = File.ReadAllText(openFilePath);
            textBoxPath_KDA.Text = textBoxPath_KDA.Text + " " + openFileDialog_KDA.FileName;
            buttonDone_KDA.Enabled = true;
        }
    }
}
