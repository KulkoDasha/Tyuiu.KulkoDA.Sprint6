using Tyuiu.KulkoDA.Sprint6.Task0.V28.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task0.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBoxVarX_Keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void buttonDone_KDA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KDA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(TextBoxVarX.Text)));
            }
            catch
            {
                MessageBox.Show("ошибка", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("====");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
