using Tyuiu.KulkoDA.Sprint6.Task2.V2.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task2.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_KDA_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBoxStart_KDA.Text);
                int z = Convert.ToInt32(textBoxEnd_KDA.Text);
                
                int len = ds.GetMassFunction(a, z).Length;
                double[] mass;
                mass = new double[len];
                mass = ds.GetMassFunction(a, z);
                
                for (int i = 0; i < len; i++)
                {
                    this.dataGridView1.Rows.Add(Convert.ToString(a), Convert.ToString(mass[i]));
                    a++;
                }
                
            }
            catch
            {
                MessageBox.Show("ошибка", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button_KDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск2 выполнила студентка группы ИИПб-24-2 Кулько Дарья Андреевна");
        }
    }
}
