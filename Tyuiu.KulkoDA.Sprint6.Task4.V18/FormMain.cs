using Tyuiu.KulkoDA.Sprint6.Task4.V18.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task4.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBoxStart.Text);
                int z = Convert.ToInt32(textBoxEnd.Text);

                int len = ds.GetMassFunction(a, z).Length;
                double[] mass;
                mass = new double[len];
                mass = ds.GetMassFunction(a, z);

                for (int i = 0; i < len; i++)
                {
                    textBoxDone.AppendText(mass[i] + Environment.NewLine);
                    a++;
                }

            }
            catch
            {
                MessageBox.Show("ошибка", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск4 выполнила студентка группы ИИПб-24-2 Кулько Дарья Андреевна");
        }
    }
}
